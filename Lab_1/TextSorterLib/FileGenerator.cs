﻿using System;
using System.IO;
using System.Text;

namespace TextSorterLib
{
    /// <summary>
    /// Generates a file with random text.
    /// </summary>
    public static class FileGenerator
    {
        private static readonly Random Random = new Random();

        private static readonly char[] Alphabet =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        /// <summary>
        /// Generates a file with random content in the specified encoding and size.
        /// </summary>
        /// <param name="pathToGeneratedFile">Path to save the generated file.</param>
        /// <param name="sizeOfFileToBeGenerated">The size in bytes of the file to be generated.</param>
        /// <param name="encoding">The encoding in which to generate the file.</param>
        public static void GenerateRandomFile(string pathToGeneratedFile,
            long sizeOfFileToBeGenerated, Encoding encoding)
        {
            const byte minWordLength = 3;
            const byte maxWordLength = 15;

            const byte minWordsInString = 20;
            const byte maxWordsInString = 75;

            sizeOfFileToBeGenerated = GetFileSizeBasedOnEncoding(sizeOfFileToBeGenerated, encoding);

            using (var fileStream = File.OpenWrite(pathToGeneratedFile))
            using (var streamWriter = new StreamWriter(fileStream, encoding))
            {
                long currentWriteableByte = 0;
                while (currentWriteableByte < sizeOfFileToBeGenerated)
                {
                    int wordLength = Random.Next(minWordLength, maxWordLength);
                    int stringLength = Random.Next(minWordsInString, maxWordsInString);

                    for (int currentWritableWordInString = 0;
                        currentWritableWordInString < stringLength;
                        currentWritableWordInString++)
                    {
                        for (int currentWritableCharInWord = 0;
                            currentWritableCharInWord < wordLength;
                            currentWritableCharInWord++)
                        {
                            streamWriter.Write(Alphabet[Random.Next(0, Alphabet.Length - 1)]);

                            currentWriteableByte++;
                        }

                        streamWriter.Write(' ');
                        currentWriteableByte++;
                    }

                    streamWriter.Write('\n');
                    currentWriteableByte++;
                }
            }
        }

        /// <summary>
        /// Calculates the size of a file in bytes based on encoding.
        /// </summary>
        /// <param name="sizeOfFileToBeGenerated">The size in bytes of the file to be generated.</param>
        /// <param name="encoding">The encoding in which to generate the file.</param>
        /// <returns>File size in bytes including encoding.</returns>
        private static long GetFileSizeBasedOnEncoding(long sizeOfFileToBeGenerated, Encoding encoding)
        {
            if (Equals(encoding, Encoding.Unicode) || Equals(encoding, Encoding.BigEndianUnicode))
            {
                return sizeOfFileToBeGenerated / 2;
            }

            if (Equals(encoding, Encoding.UTF32))
            {
                return sizeOfFileToBeGenerated / 4;
            }

            return sizeOfFileToBeGenerated;
        }
    }
}