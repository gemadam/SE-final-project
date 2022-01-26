using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    /// <summary>
    /// Main data structure of the program. Allows to store file mappings and resolve conflicts.
    /// </summary>
    public class MappedFilesCollection
    {
        /// <summary>
        /// Underlaying structure that stores all of the data.
        /// </summary>
        public IDictionary<string, List<FileInfo>> mappedFiles { private get; set; }


        /// <summary>
        /// Default constructor.
        /// </summary>
        public MappedFilesCollection()
        {
            mappedFiles = new Dictionary<string, List<FileInfo>>();
        }


        /// <summary>
        /// Function adds new file mapping.
        /// </summary>
        /// <param name="fileOutput">File mapping</param>
        /// <param name="file">File input info</param>
        public void Add(string fileOutput, FileInfo file)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                mappedFiles[fileOutput].Add(file);
            else
                mappedFiles[fileOutput] = new List<FileInfo> { file };
        }

        /// <summary>
        /// Function adds new files mapping. <strong>Creates conflict, if files count is > 1!</strong>
        /// </summary>
        /// <param name="fileOutput">Files mapping</param>
        /// <param name="files">Collection of input files info</param>
        public void Add(string fileOutput, ICollection<FileInfo> files)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                mappedFiles[fileOutput].AddRange(files);
            else
                mappedFiles[fileOutput] = files.ToList();
        }


        /// <summary>
        /// Function moves input file info from one mapping to another. Can be used to resolve conflicts.
        /// </summary>
        /// <param name="fileOutput">Current file mapping</param>
        /// <param name="newFileOutput">New file mapping</param>
        /// <param name="file">Input file info</param>
        public void Move(string fileOutput, string newFileOutput, FileInfo file)
        {
            if (mappedFiles.ContainsKey(fileOutput) && !fileOutput.Equals(newFileOutput))
            {
                var mappedFilesCopy = mappedFiles[fileOutput].Where(x => file.Equals(x)).ToList();

                this.Add(newFileOutput, mappedFilesCopy);
                this.Remove(fileOutput, mappedFilesCopy);
            }
        }


        /// <summary>
        /// Function removes file info from a specific mapping.
        /// </summary>
        /// <param name="fileOutput">File mapping</param>
        /// <param name="file">Input file info</param>
        public void Remove(string fileOutput, FileInfo file)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                this.Remove(fileOutput, mappedFiles[fileOutput].Where(x => file.Equals(x)).ToList());
        }


        /// <summary>
        /// Function removes a collection of files info from a specific mapping.
        /// </summary>
        /// <param name="fileOutput">File mapping</param>
        /// <param name="files">Input files info</param>
        public void Remove(string fileOutput, ICollection<FileInfo> files)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                mappedFiles[fileOutput].RemoveAll(x => files.Contains(x));
        }


        /// <summary>
        /// Function returns the first conflict.
        /// </summary>
        /// <returns>Conflict info</returns>
        public KeyValuePair<string, List<FileInfo>> FirstConflict()
        {
            return mappedFiles.Where(x => x.Value.Count > 1).First();
        }


        /// <summary>
        /// Function returns the number of conflicts.
        /// </summary>
        /// <returns>Number of conflicts.</returns>
        public int ConflictsCount()
        {
            return mappedFiles.Where(x => x.Value.Count > 1).Count();
        }


        /// <summary>
        /// Function returns the number of conflicted files.
        /// </summary>
        /// <returns>Number of conflicted files.</returns>
        public int ConflictedFilesCount()
        {
            return mappedFiles.Where(x => x.Value.Count > 1)
                .Select(x => x.Value.Count)
                .Sum();
        }


        /// <summary>
        /// Function resolves a conflict.
        /// </summary>
        /// <param name="conflictedOutput">Common mapping of files A and B taht caused a caonflict.</param>
        /// <param name="fileA">Input file info A</param>
        /// <param name="fileB">Input file info B</param>
        /// <param name="outA">New mapping of file A, null if file A should be removed from mapping</param>
        /// <param name="outB">New mapping of file B, null if file B should be removed from mapping</param>
        public void ResolveConflict(string conflictedOutput, FileInfo fileA, FileInfo fileB, string outA, string outB)
        {
            if (outA == null)                           // Skip file A
                this.Remove(conflictedOutput, fileA);
            else                                        // Change output of file A
                this.Move(conflictedOutput, outA, fileA);

            if (outB == null)                           // Skip file B
                this.Remove(conflictedOutput, fileB);
            else                                        // Change output of file B
                this.Move(conflictedOutput, outB, fileB);
        }


        /// <summary>
        /// Method converts collection to resolved dictionary.
        /// </summary>
        /// <param name="ignoreConflicts">Suspress conflicts mode.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">When not suspressed conflict occurs.</exception>
        public IDictionary<string, FileInfo> AsResolvedDictionary(bool ignoreConflicts = false)
        {
            var result = new Dictionary<string, FileInfo>();

            foreach (var file in mappedFiles)
            {
                if (file.Value.Count() == 1)
                    result.Add(file.Key, file.Value[0]);
                else if (!ignoreConflicts)
                    throw new InvalidOperationException();
            }

            return result;
        }


        /// <summary>
        /// Function converts entries in the structure to collection of strings in format:
        /// <code>input_file -> file_mapping</code>
        /// </summary>
        /// <returns>Collection of string representations of entries.</returns>
        public IList<string> AsStringCollection()
        {
            var result = new List<string>();

            foreach (var file in mappedFiles)
            {
                if (file.Value.Count == 1)
                    result.Add($"{file.Value.First()} ➡ {file.Key}");
                else
                {
                    foreach (var conflictFile in file.Value)
                        result.Add($"{conflictFile} ➡ {file.Key}");
                }
            }

            return result;
        }
    }
}
