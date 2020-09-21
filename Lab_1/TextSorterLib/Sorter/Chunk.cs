using System;
using System.IO;
using System.Text;

namespace TextSorterLib.Sorter
{
    /// <summary>
    /// Allows to work with chunks.
    /// </summary>
    public class Chunk
    {
        private readonly StreamWriter _streamWriter;

        /// <summary>
        /// The name of the file, containing sorted lines starting with the given substring.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Chunk size in bytes.
        /// </summary>
        public long Size { get; private set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Chunk"/>.
        /// </summary>
        /// <param name="encoding">Chunk encoding.</param>
        public Chunk(Encoding encoding)
        {
            FileName = GenerateFileName();
            _streamWriter = new StreamWriter(FileName, false, encoding);
        }

        /// <summary>
        /// Appends a string to the writer stream.
        /// </summary>
        /// <param name="stringToAppend">A string to append to the writer stream.</param>
        /// <param name="encoding">Chunk encoding.</param>
        public void Append(string stringToAppend, Encoding encoding)
        {
            _streamWriter.WriteLine(stringToAppend);
            Size += encoding.GetByteCount(stringToAppend) + encoding.GetByteCount(Environment.NewLine);
        }

        /// <summary>
        /// Closes the current StreamWriter object and the underlying stream.
        /// </summary>
        public void Flush()
        {
            _streamWriter?.Close();
        }

        /// <summary>
        /// Generates a chunk name.
        /// </summary>
        /// <returns>Chunk name.</returns>
        private static string GenerateFileName()
        {
            return $"tmp/Chunk{Sorter.CurrentChunkNumber}.txt";
        }
    }
}
