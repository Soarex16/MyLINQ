using System;
using System.Collections.Generic;
using MyLinq;
using NUnit.Framework;

namespace MyLinq.Tests {
    [TestFixture]
    public class FirstTest {

        [Test]
        public void First_Empty_InvalidOperationExceptionThrown() {
            // Arrange
            var arr = new int[0];

            // Act

            // I can't separate Act and Assert,
            // because it throws an exception, that I need to caught

            //Assert
            Assert.That(() => arr.First(), Throws.InvalidOperationException);
        }

        [Test]
        public void FirstWithPredicate_WithoutProperElement_InvalidOperationExceptionThrown() {
            // Arrange
            string[] arr = {"test", "fixture", "without", "appropriate", "method"};
            Func<string, bool> predicate = s => s.Length == 1;

            // Act

            // And again I need to combine Act and Assert

            // Assert
            Assert.That(() => arr.First(predicate), Throws.InvalidOperationException);
        }

        [Test]
        public void First_PredicateNull_ArgumentNullException() {
            // Arrange
            string[] arr = {"test", "fixture", "without", "appropriate", "method"};
            Func<string, bool> predicate = null;

            // Act

            // Assert
            Assert.That(() => arr.First(predicate), Throws.ArgumentNullException);
        }
    }
}