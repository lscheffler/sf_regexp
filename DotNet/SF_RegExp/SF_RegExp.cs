/**************************************************************************************************
 * Name space: SF_RegExp
 * 
 * Purpose: C# class to provide DotNet access and support to DotNetRegExp for Visual FoxPro reports
 * 
 * To use in VFP9 or VFPA with wwDotNetBridge
 * 
 * Class: SF_RegExp
 * Purpose: Classdefinition
 * 
 * RegExp support
 * There are problems to acces parts of RegExp directly throug wwDotNetBridge
 * 
 * Lutz Scheffler Software Ingenieurbüro
 * 
 * File History:
 * Date             Who             Comment
 * 2023/04/23       SF              File creation.
 ***************************************************************************************************/

// https://learn.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netframework-4.8

using System;
using System.Text.RegularExpressions;

///<summary>
///Interface to expose RegExp to VFP
///Use wwDotNetBridge in case
/// </summary>
namespace SF_RegExp
{
    /// <summary>
    /// Wrap RegExp Interface
    /// </summary>
    public class SF_RegExp
    {
        #region Variables

        /// <summary>
        /// A reference to the RegExp
        /// </summary>
        private Regex _regexp = null;

        private string _pattern = "";

        /// <summary>
        /// Options used for to create the RegExp
        /// </summary>
        private RegexOptions Options = RegexOptions.IgnoreCase;
        //        private RegexOptions options;

        #endregion Variables

        #region Properties
        //        private static int IdCounter = 0;

        //                public int Id = ++IdCounter;

        /// <summary>
        /// Pattern to use in the regexp
        /// </summary>
        public string Pattern
        {
            get
            {
                if (_regexp == null)
                { return _pattern; }
                else
                { return _regexp.ToString(); }
            }
//            set ; }
            set
            {
                if (_pattern != value)
                { _regexp = null; }
                _pattern = value;
            }
        }

        /// <summary>
        /// Regex.CacheSize Property
        /// </summary>
        public static int CacheSize
        {
            get
            { return Regex.CacheSize;  }
            set
            { Regex.CacheSize = value; }
        }

        /// <summary>
        /// Timeout in seconds
        /// Returns 0 if no regexp is run
        /// </summary>
        public double? MatchTimeout
        {
            get
            {
                if (_regexp == null)
                { return null; }
                else
                { return _regexp.MatchTimeout.TotalSeconds; }
            }
        }
        
        #region Options
        public bool Compiled                 //   8
        {
            get
            {
                if (_regexp == null)
                { return (Options & RegexOptions.Compiled) != 0; }
                else
                { return (_regexp.Options & RegexOptions.Compiled) != 0; }
            }
            set
            {
                if (Compiled != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.Compiled; }
                else
                { Options &= ~RegexOptions.Compiled; }
            }
        }
        public bool CultureInvariant         // 512
        {
            get
             {
                if (_regexp == null)
                { return (Options & RegexOptions.CultureInvariant) != 0; }
                else
                { return (_regexp.Options & RegexOptions.CultureInvariant) != 0; }
            }
            set
            {
                if (CultureInvariant != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.CultureInvariant; }
                else
                { Options &= ~RegexOptions.CultureInvariant; }
            }
        }
        public bool ECMAScript               // 256
        {
            get
             {
                if (_regexp == null)
                { return (Options & RegexOptions.ECMAScript) != 0; }
                else
                { return (_regexp.Options & RegexOptions.ECMAScript) != 0; }
            }
            set
            {
                if (ECMAScript != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.ECMAScript; }
                else
                { Options &= ~RegexOptions.ECMAScript; }
            }
        }
        public bool ExplicitCapture          //   4
        {
            get
             {
                if (_regexp == null)
                { return (Options & RegexOptions.ExplicitCapture) != 0; }
                else
                { return (_regexp.Options & RegexOptions.ExplicitCapture) != 0; }
            }
            set
            {
                if (ExplicitCapture != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.ExplicitCapture; }
                else
                { Options &= ~RegexOptions.ExplicitCapture; }
            }
        }
        public bool IgnoreCase               //   1
        {
            get
             {
                if (_regexp == null)
                { return (Options & RegexOptions.IgnoreCase) != 0; }
                else
                { return (_regexp.Options & RegexOptions.IgnoreCase) != 0; }
            }
            set
            {
                if (IgnoreCase != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.IgnoreCase; }
                else
                { Options &= ~RegexOptions.IgnoreCase; }
            }
        }
        public bool IgnorePatternWhitespace  //  32
        {
            get
            {
                if (_regexp == null)
                { return (Options & RegexOptions.IgnorePatternWhitespace) != 0; }
                else
                { return (_regexp.Options & RegexOptions.IgnorePatternWhitespace) != 0; }
            }
            set
            {
                if (IgnorePatternWhitespace != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.IgnorePatternWhitespace; }
                else
                { Options &= ~RegexOptions.IgnorePatternWhitespace; }
            }
        }
        public bool Multiline                //   2
        {
            get
             {
                if (_regexp == null)
                { return (Options & RegexOptions.Multiline) != 0; }
                else
                { return (_regexp.Options & RegexOptions.Multiline) != 0; }
            }
            set
            {
                if (Multiline != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.Multiline; }
                else
                { Options &= ~RegexOptions.Multiline; }
            }
        }
        public bool RightToLeft              //  64
        {
            get
             {
                if (_regexp == null)
                { return (Options & RegexOptions.RightToLeft) != 0; }
                else
                { return (_regexp.Options & RegexOptions.RightToLeft) != 0; }
            }
            set
            {
                if (RightToLeft != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.RightToLeft; }
                else
                { Options &= ~RegexOptions.RightToLeft; }
            }
        }
        public bool Singleline               //  16
        {
            get
            {
                if (_regexp == null)
                { return (Options & RegexOptions.Singleline) != 0; }
                else
                { return (_regexp.Options & RegexOptions.Singleline) != 0; }
            }
            set
            {
                if (Singleline != value)
                { _regexp = null; }
                if (value)
                { Options |= RegexOptions.Singleline; }
                else
                { Options &= ~RegexOptions.Singleline; }
            }
        }
        #endregion Options

        #endregion Properties

        /*        #region Constructor
                public SF_RegExp(string pattern)
                {
                    _regexp = new Regex(pattern);
                }

                public SF_RegExp(string pattern, System.Text.RegularExpressions.RegexOptions options)
                {
                    _regexp = new Regex(pattern, options);
                }
                #endregion Constructor
        */

        #region RegExp methods
        private void newRegExp()
        { _regexp = new Regex(_pattern, Options); }

        /// <summary>
        /// Escapes a minimal set of characters (\, *, +, ?, |, {, [, (,), ^, $, ., #, and white space) by replacing them with their escape codes.
        /// This instructs the regular expression engine to interpret these characters literally rather than as metacharacters.
        /// </summary>
        public string Escape(string str)
        {
            return Regex.Escape(str);
        }

        /// <summary>
        /// Converts any escaped characters in the input string.
        /// </summary>
        public string Unescape(string str)
        {
            return Regex.Unescape(str);
        }

        /// <summary>
        /// Returns an array of capturing group names for the regular expression.
        /// </summary>
        public string [] GetGroupNames()
        {
            if (_regexp == null)
            { return new string[] {}; }
            else
            { return _regexp.GetGroupNames(); }
        }

        /// <summary>
        /// Returns an array of capturing group numbers that correspond to group names in an array.
        /// </summary>
        public int[] GetGroupNumbers()
        {
            if (_regexp == null)
            { return new int[] {}; }
            else
            { return _regexp.GetGroupNumbers(); }
        }

        /// <summary>
        /// Gets the group name that corresponds to the specified group number.
        /// </summary>
        public string GroupNameFromNumber(int i)
        {
            if (_regexp == null)
            { return null; }
            else
            { return _regexp.GroupNameFromNumber(i); }
        }

        /// <summary>
        /// Returns the group number that corresponds to the specified group name.
        /// </summary>
        public int? GroupNumberFromName(string name)
        {
            if (_regexp == null)
            { return null; }
            else
            { return _regexp.GroupNumberFromName(name); }
        }

        #region IsMatch
        /// <summary>
        /// Indicates whether the regular expression finds a match in the input string.
        /// </summary>
        public bool IsMatch(string input)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.IsMatch(input);
        }
        public bool IsMatch(string input, string pattern)
        {
            _regexp = new Regex(pattern, Options);
            return _regexp.IsMatch(input);
        }
        public bool IsMatch(string input, int startat)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.IsMatch(input, startat);
        }
        #endregion IsMatch

        #region Match
        /// <summary>
        /// Searches an input string for a substring that matches a regular expression pattern and returns the first occurrence as a single Match object.
        /// </summary>
        public Match Match(string input)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Match(input);
        }
        public Match Match(string input, string pattern)
        {
            _regexp = new Regex(pattern, Options);
            return _regexp.Match(input);
        }
        public Match Match(string input, int startat)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Match(input, startat);
        } 
        public Match Match(string input, int startat, int length)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Match(input, startat, length);
        }
        #endregion Match

        #region Matches
        /// <summary>
        /// Searches an input string for all occurrences of a regular expression and returns all the matches.
        /// </summary>
        public MatchCollection Matches(string input)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Matches(input);
        }
        public MatchCollection Matches(string input, string pattern)
        {
            _regexp = new Regex(pattern, Options);
            return _regexp.Matches(input);
        }
        public MatchCollection Matches(string input, int startat)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Matches(input, startat);
        }
        #endregion Matches

        #region Replace
        /// <summary>
        /// In a specified input string, replaces strings that match a regular expression pattern with a specified replacement string
        /// </summary>
        public string Replace(string input, string replacement)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Replace(input, replacement);
        }
        public string Replace(string input, string pattern, string replacement)
        {
            _regexp = new Regex(pattern, Options);
            return _regexp.Replace(input, replacement);
        }
        public string Replace(string input, string replacement, int count)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Replace(input, replacement, count);
        }
        public string Replace(string input, string replacement, int count, int startat)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Replace(input, replacement, count, startat);
        }
        #endregion Replace

        #region Split
        /// <summary>
        /// Splits an input string into an array of substrings at the positions defined by a regular expression match.
        /// </summary>
        public string[] Split(string input)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Split(input);
        }
        public string[] Split(string input, string pattern)
        {
            _regexp = new Regex(pattern, Options);
            return _regexp.Split(input);
        }
        public string[] Split(string input, int startat)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Split(input, startat);
        }
        public string[] Split(string input, int startat, int length)
        {
            if (_regexp == null)
            { newRegExp(); }
            return _regexp.Split(input, startat, length);
        }
        #endregion Split

        #endregion RegExp methods
    }
}
