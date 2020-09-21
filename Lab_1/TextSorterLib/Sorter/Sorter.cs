using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextSorterLib.Sorter
{
    /// <summary>
    /// Sorter for huge text files.
    /// </summary>
    public class Sorter
    {
        private readonly SortedDictionary<string, Chunk> _chunks;

        /// <summary>
        /// Current chunk number.
        /// </summary>
        public static int CurrentChunkNumber { get; private set; }

        /// <summary>
        /// Comparer that is used to sort strings in the file.
        /// </summary>
        public StringComparer Comparer { get; }

        /// <summary>
        /// File encoding to be sorted.
        /// </summary>
        public Encoding Encoding { get; }

        /// <summary>
        /// The maximum file size that can be loaded into memory for sorting.
        /// </summary>
        public long MaxFileSize { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="Sorter"/>.
        /// </summary>
        public Sorter()
        {
            Comparer = StringComparer.Ordinal;
            Encoding = Encoding.Unicode;
            MaxFileSize = 1024 * 1024 * 100;

            _chunks = new SortedDictionary<string, Chunk>(Comparer);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Sorter"/>.
        /// </summary>
        /// <param name="comparer">Comparer that is used to sort strings in the file.</param>
        /// <param name="encoding">File encoding to be sorted.</param>
        /// <param name="maxFileSize">The maximum file size that can be loaded into memory for sorting.</param>
        public Sorter(StringComparer comparer, Encoding encoding, long maxFileSize)
        {
            Comparer = comparer;
            Encoding = encoding;
            MaxFileSize = maxFileSize;

            _chunks = new SortedDictionary<string, Chunk>(Comparer);
        }

        /// <summary>
        /// Sorts a huge file.
        /// </summary>
        /// <param name="pathToSourceFile">The path to the file to be sorted.</param>
        /// <param name="pathToSortedFile">The path to save the sorted file.</param>
        public void Sort(string pathToSourceFile, string pathToSortedFile)
        {
            var infoAboutFileToBeSorted = new FileInfo(pathToSourceFile);
    
            if (infoAboutFileToBeSorted.Length < MaxFileSize)
            {
                SortFile(pathToSourceFile, pathToSortedFile);
            }
            else
            {
                var tempDirectoryInfo = new DirectoryInfo("tmp");
                if (tempDirectoryInfo.Exists)
                {
                    tempDirectoryInfo.Delete(true);
                }

                tempDirectoryInfo.Create();

                SplitFileIntoChunks(pathToSourceFile, 1);
                MergeChunks(pathToSortedFile);

                tempDirectoryInfo.Delete(true);
            }
        }

        /// <summary>
        /// Merges all chunks into the resulting file.
        /// </summary>
        /// <param name="pathToFile">The path to the file where you want to merge the chunks.</param>
        private void MergeChunks(string pathToFile)
        {
            using (var fileStream = File.Create(pathToFile))
            {
                foreach (var currentChunk in _chunks)
                {
                    currentChunk.Value.Flush();

                    CopyFile(currentChunk.Value.FileName, fileStream);

                    File.Delete(currentChunk.Value.FileName);
                }
            }
        }

        /// <summary>
        /// Splits a huge file into chunks, matching the leading characters on each line of the file.
        /// </summary>
        /// <param name="pathToSourceFile">The path to the file to be split into chunks.</param>
        /// <param name="numberOfLeadingChars">The number of leading characters per line to split into chunks.</param>
        private void SplitFileIntoChunks(string pathToSourceFile, int numberOfLeadingChars)
        {
            var tempFiles = new Dictionary<string, Chunk>(Comparer);

            using (var streamReader = new StreamReader(pathToSourceFile, Encoding))
            {
                while (streamReader.Peek() > -1)
                {
                    string currentLine = streamReader.ReadLine();

                    if (string.IsNullOrEmpty(currentLine))
                    {
                        continue;
                    }

                    string beginningOfLine = currentLine.Substring(0, numberOfLeadingChars);

                    if (!tempFiles.TryGetValue(beginningOfLine, out var fileChunk))
                    {
                        CurrentChunkNumber++;
                        fileChunk = new Chunk(Encoding);
                        tempFiles.Add(beginningOfLine, fileChunk);
                    }

                    fileChunk.Append(currentLine, Encoding);
                }
            }

            foreach (var currentTempFile in tempFiles)
            {
                currentTempFile.Value.Flush();

                if (currentTempFile.Value.Size > MaxFileSize)
                {
                    SplitFileIntoChunks(currentTempFile.Value.FileName, numberOfLeadingChars + 1);

                    File.Delete(currentTempFile.Value.FileName);
                }
                else
                {
                    SortFile(currentTempFile.Value.FileName, currentTempFile.Value.FileName);

                    if (!_chunks.TryGetValue(currentTempFile.Key, out _))
                    {
                        _chunks.Add(currentTempFile.Key, currentTempFile.Value);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts the contents of the specified file.
        /// </summary>
        /// <param name="pathToSourceFile">The path to the file to be sorted.</param>
        /// <param name="pathToSortedFile">The path to save the sorted file.</param>
        private void SortFile(string pathToSourceFile, string pathToSortedFile)
        {
            var listOfLines = new List<string>();

            using (var streamReader = new StreamReader(pathToSourceFile, Encoding))
            {
                while (streamReader.Peek() > -1)
                {
                    listOfLines.Add(streamReader.ReadLine());
                }
            }

            listOfLines.Sort(Comparer);

            using (var streamWriter = new StreamWriter(pathToSortedFile, false, Encoding))
            {
                foreach (string line in listOfLines)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Copies the contents of a file to a file stream.
        /// </summary>
        /// <param name="pathToSourceFileName">The path to the file to be copied to the file stream.</param>
        /// <param name="outputFileStream">Output file stream.</param>
        private static void CopyFile(string pathToSourceFileName, FileStream outputFileStream)
        {
            if (string.IsNullOrEmpty(pathToSourceFileName))
            {
                throw new ArgumentNullException(nameof(pathToSourceFileName));
            }

            if (outputFileStream == null)
            {
                throw new ArgumentNullException(nameof(outputFileStream));
            }

            using (var file = File.OpenRead(pathToSourceFileName))
            {
                file.CopyTo(outputFileStream);
            }
        }
    }
}
