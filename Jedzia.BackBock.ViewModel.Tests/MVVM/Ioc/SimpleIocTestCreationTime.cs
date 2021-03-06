﻿namespace Jedzia.BackBock.ViewModel.Tests.MVVM.Ioc
{
    using Jedzia.BackBock.ViewModel.MVVM.Ioc;
    using Jedzia.BackBock.ViewModel.Tests.MVVM.Stubs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SimpleIocTestCreationTime
    {
        [TestMethod]
        public void TestCreationTimeForDefaultInstance()
        {
            SimpleIoc.Default.Reset();
            TestClassForCreationTime.Reset();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.Register<TestClassForCreationTime>();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>();
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>();
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
        }

        [TestMethod]
        public void TestCreationTimeForNamedInstance()
        {
            SimpleIoc.Default.Reset();
            TestClassForCreationTime.Reset();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.Register<TestClassForCreationTime>();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>("Key1");
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>("Key2");
            Assert.AreEqual(2, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>("Key1");
            Assert.AreEqual(2, TestClassForCreationTime.InstancesCreated);
        }

        [TestMethod]
        public void TestCreationTimeWithInterfaceForDefaultInstance()
        {
            SimpleIoc.Default.Reset();
            TestClassForCreationTime.Reset();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.Register<ITestClass, TestClassForCreationTime>();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<ITestClass>();
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<ITestClass>();
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
        }

        [TestMethod]
        public void TestCreationTimeWithInterfaceForNamedInstance()
        {
            SimpleIoc.Default.Reset();
            TestClassForCreationTime.Reset();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.Register<ITestClass, TestClassForCreationTime>();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<ITestClass>("Key1");
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<ITestClass>("Key2");
            Assert.AreEqual(2, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<ITestClass>("Key1");
            Assert.AreEqual(2, TestClassForCreationTime.InstancesCreated);
        }

        [TestMethod]
        public void TestCreationTimeWithFactory()
        {
            SimpleIoc.Default.Reset();
            TestClassForCreationTime.Reset();
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.Register(() => new TestClassForCreationTime());
            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>();
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>();
            Assert.AreEqual(1, TestClassForCreationTime.InstancesCreated);
        }

        [TestMethod]
        public void TestCreationOfMultipleInstances()
        {
            SimpleIoc.Default.Reset();
            TestClassForCreationTime.Reset();

            var factoryWasUsed = 0;

            SimpleIoc.Default.Register(() =>
            {
                factoryWasUsed++;
                return new TestClassForCreationTime();
            });

            Assert.AreEqual(0, TestClassForCreationTime.InstancesCreated);

            SimpleIoc.Default.GetInstance<TestClassForCreationTime>();
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>("Key1");
            SimpleIoc.Default.GetInstance<TestClassForCreationTime>("Key2");

            Assert.AreEqual(3, TestClassForCreationTime.InstancesCreated);
            Assert.AreEqual(3, factoryWasUsed);

        }
    }
}
