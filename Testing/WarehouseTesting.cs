using System;
using System.Collections.Generic;
using NUnit.Framework;
using Warehouse_Replenishment;

namespace Testing
{
    [TestFixture]
    public class WarehouseTesting
    {
        StockMonitor m;
        [SetUp]
        public void Setup()
        {
            m = new StockMonitor();
        }
        [Test]
        public void Add()
        {
            m.Add(new StockItem("A", 10, "Flood"));
            Assert.That(m, Is.Not.Null);
        }
        [Test]
        public void Rule()
        {
            Predicate<StockItem> rule = m.CreateReorderRule(5);
            Assert.That(rule(new StockItem("A", 10, "Food")), Is.True);
        }
        [Test]
        public void RuleNew()
        {
            Predicate<StockItem> rule = m.CreateReorderRule(10);
            Assert.That(rule(new StockItem("B", 5, "Cleaning")), Is.False);
        }
        [Test]
        public void SkuException()
        {
            Assert.That(() => m.AdjustStock("A", 2), Throws.TypeOf<KeyNotFoundException>());
        }
        [Test]
        public void NegativeStockThrowsException()
        {
            m.Add(new StockItem("A", 1, "Food"));
            Assert.That(() => m.AdjustStock("A", -2), Throws.TypeOf<NegativeStockException>());
        }
        [Test]
        public void Action()
        {
            bool b = false;
            m.LogStock(new StockItem("A", 1, "Food"), item => b = true);
            Assert.That(b, Is.True);
        }
        [Test]
        public void EventRuns()
        {
            bool b = false;
            m.Event += (sender, args) => b = true;
            m.RaiseReplenishment(new StockItem("A", 1, "Food"));
            Assert.That(b, Is.True);
        }
        [Test]
        public void RefrigeratedItemIsFound()
        {
            bool result = m.Refrigerated(new StockItem("A", 1, "Food"));
            Assert.That(result, Is.True);
        }
    }
}
