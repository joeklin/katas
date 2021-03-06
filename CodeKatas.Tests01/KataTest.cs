// <copyright file="KataTest.cs">Copyright ©  2017</copyright>
using System;
using CodeKatas.Likes;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKatas.Likes.Tests
{
    /// <summary>This class contains parameterized unit tests for Kata</summary>
    [PexClass(typeof(Kata))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class KataTest
    {
        /// <summary>Test stub for Likes(String[])</summary>
        [PexMethod]
        public string LikesTest(string[] names)
        {
            string result = Kata.Likes(names);
            return result;
            // TODO: add assertions to method KataTest.LikesTest(String[])
        }
    }
}
