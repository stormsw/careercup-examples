/// <summary>
/// Character arranger.
/// </summary>
namespace RearrangeChars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Character arranger.
    /// </summary>
    public class CharacterArranger
    {
        /// <summary>
        /// The input.
        /// </summary>
        private string input;

        /// <summary>
        /// Initializes a new instance of the <see cref="RearrangeChars.CharacterArranger"/> class.
        /// </summary>
        /// <param name="input">Input.</param>
        public CharacterArranger (string input)
        {
            this.input = input;
        }

        /// <summary>
        /// Arrange this instance.
        /// </summary>
        public string arrange ()
        {
            string result = "No valid output";
            if (!string.IsNullOrWhiteSpace (input) && input.Length > 1) {
                List<char> inputList = new List<char> (input.ToCharArray ());
                bool notFound = false;
                char pred = input [0];
                for (int i = 1; i < input.Length; i++) {
                    if (inputList [i] == pred) {
                        notFound = true;
                        for (var j = i + 1; j < input.Length; j++) {
                            if (inputList [j] != pred) {
                                inputList [i] = inputList [j];
                                inputList [j] = pred;
                                notFound = false;
                                break;
                            }
                        }

                        if (notFound) {
                            /// lookup bakcward  for double chars to insert there
                            for (var k = 0; k < i; k++) {
                                if (inputList [k] != pred && inputList [k + 1] != pred) {
                                    inputList.Insert (k + 1, pred);
                                    inputList.RemoveAt (i);
                                    notFound = false;
                                    break;
                                }
                            }
                        }

                        if (notFound)
                            break;
                    }
                    pred = inputList [i];
                }
                if (!notFound) {
                    result = string.Join (string.Empty, inputList.ToArray ());
                }
            }
            return result;
        }

        /// <summary>
        /// Is characters are valid for rearrange
        /// Any char class count is less ten summ of all others +1
        /// </summary>
        public bool Valid ()
        {
            /// it is possible if there not any chars amount > sum max other chars + 1
            bool result = true;

            /// Dictionary<
            /// HashSet<KeyValuePair<Char, int>> charClass = new HashSet<KeyValuePair<char, int>>();
            /// input.ToCharArray().ToList().ForEach(item => charClass[item]++);
            return result;
        }
    }
}