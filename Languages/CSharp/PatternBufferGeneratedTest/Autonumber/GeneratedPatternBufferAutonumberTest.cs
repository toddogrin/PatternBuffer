using System;
using System.Collections.Generic;
using NUnit.Framework;
using Test.Autonumber;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferAutonumberTest {

        [Test()]
        public void TestAutonumbering() {
           Assert.AreEqual(17, new BaseThingShouldBe17().TypeId);
           Assert.AreEqual(5, new BaseThingShouldBe5().TypeId);
           Assert.AreEqual(6, new NewAbstractShouldBe6().TypeId);
           Assert.AreEqual(7, new NewAbstractShouldBe7().TypeId);
           Assert.AreEqual(8, new NewAbstractShouldBe8().TypeId);
           Assert.AreEqual(1, new ShouldBe1().TypeId);
           Assert.AreEqual(2, new ShouldBe2().TypeId);
           Assert.AreEqual(3, new ShouldBe3().TypeId);
           Assert.AreEqual(4, new ShouldBe4().TypeId);
           Assert.AreEqual(57, new ShouldBe57().TypeId);
        }

    }

}