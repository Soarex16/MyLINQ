using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MyLinq.Tests {
    [TestFixture]
    public class AnyTest {

        [Test]
        public void Any_EmptyList_False() {
            var list = new List<int>();

            bool res = list.Any();

            Assert.That(res, Is.False);
        }

        [Test]
        public void Any_IntList_True() {
            var list = new List<int>() {
                1, 2, 3, 4, 5
            };

            bool res = list.Any();

            Assert.That(res, Is.True);
        }

        [Test]
        public void AnyWithPredicate_IntList_True() {
            var list = new List<int>() {
                1, 2, 3, 4, 5
            };
            Func<int, bool> predicate = i => i % 2 == 0;

            bool res = list.Any(predicate);

            Assert.That(res, Is.True);
        }

        [Test]
        public void AnyWithPredicate_EmptyList_False() {
            var list = new List<int>();
            Func<int, bool> predicate = i => i % 2 == 0;

            bool res = list.Any();

            Assert.That(res, Is.False);
        }
    }
}