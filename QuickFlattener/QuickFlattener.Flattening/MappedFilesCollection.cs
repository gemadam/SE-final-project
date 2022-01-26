using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFlattener.Flattening
{
    public class MappedFilesCollection
    {
        public IDictionary<string, List<FileInfo>> mappedFiles { set; get; }


        public MappedFilesCollection()
        {
            mappedFiles = new Dictionary<string, List<FileInfo>>();
        }

        public void Add(string fileOutput, FileInfo file)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                mappedFiles[fileOutput].Add(file);
            else
                mappedFiles[fileOutput] = new List<FileInfo> { file };
        }

        public void Add(string fileOutput, ICollection<FileInfo> files)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                mappedFiles[fileOutput].AddRange(files);
            else
                mappedFiles[fileOutput] = files.ToList();
        }


        public void Move(string fileOutput, string newFileOutput, FileInfo file)
        {
            if (mappedFiles.ContainsKey(fileOutput) && !fileOutput.Equals(newFileOutput))
            {
                var mappedFilesCopy = mappedFiles[fileOutput].Where(x => file.Equals(x)).ToList();

                this.Add(newFileOutput, mappedFilesCopy);
                this.Remove(fileOutput, mappedFilesCopy);
            }
        }


        public void Remove(string fileOutput, FileInfo file)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                this.Remove(fileOutput, mappedFiles[fileOutput].Where(x => file.Equals(x)).ToList());
        }

        public void Remove(string fileOutput, ICollection<FileInfo> files)
        {
            if (mappedFiles.ContainsKey(fileOutput))
                mappedFiles[fileOutput].RemoveAll(x => files.Contains(x));
        }


        public KeyValuePair<string, List<FileInfo>> FirstConflict()
        {
            return mappedFiles.Where(x => x.Value.Count > 1).First();
        }


        public int ConflictsCount()
        {
            return mappedFiles.Where(x => x.Value.Count > 1).Count();
        }

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
