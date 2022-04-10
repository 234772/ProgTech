﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DataTests
    {
        DataLayerAbstractAPI dl = DataLayerAbstractAPI.CreateLinq2SQL();
        Client client = new Client("Mateusz", "Idec", 42, "c042", "mateusz.idec@interia.pl", "Łódź", "Poland", "Prosta");
        WarehouseWorker worker = new WarehouseWorker("Alexander", "Shulgin", 42, "w042", "Testing");
        Supplier supplier = new Supplier("Hunter", "Thompson", 42, "s042", "mateusz.idec@inetria.pl", "Herbs");
        Catalog catalog = new Catalog(1, "Melisa", "Calming herb");
        Catalog catalog2 = new Catalog(2, "Poppy", "Pretty flower");
        List<Product> orderedProducts = new List<Product>();

        [TestMethod]
        public void addingClient_NotNull()
        {
            dl.addClient(client);
            Assert.IsNotNull(dl.getClient(0));
        }

        [TestMethod]
        public void addingSupplier_NotNull()
        {
            dl.addSupplier(supplier);
            Assert.IsNotNull(dl.getSupplier(0));
        }

        [TestMethod]
        public void addingWorker_NotNull()
        {
            dl.addWorker(worker);
            Assert.IsNotNull(dl.getWorker(0));
        }

        [TestMethod]
        public void getterClient_Equal()
        {
            Assert.AreEqual(client.FirstName, "Mateusz");
            Assert.AreEqual(client.LastName, "Idec");
            Assert.AreEqual(client.Age, 42);
            Assert.AreEqual(client.ID, "c042");
            Assert.AreEqual(client.Email, "mateusz.idec@interia.pl");
            Assert.AreEqual(client.City, "Łódź");
            Assert.AreEqual(client.Country, "Poland");
            Assert.AreEqual(client.Street, "Prosta");
        }

        [TestMethod]
        public void getterSupplier_Equal()
        {      
            Assert.AreEqual(supplier.FirstName, "Hunter");
            Assert.AreEqual(supplier.LastName, "Thompson");
            Assert.AreEqual(supplier.Age, 42);
            Assert.AreEqual(supplier.ID, "s042");
        }

        [TestMethod]
        public void getterWorker_Equal()
        {
            Assert.AreEqual(worker.FirstName, "Alexander");
            Assert.AreEqual(worker.LastName, "Shulgin");
            Assert.AreEqual(worker.Age, 42);
            Assert.AreEqual(worker.ID, "w042");
        }

        [TestMethod]
        public void removingTest()
        {
            Product product = new Product(1, 21, 150.0f, catalog);
            Product product2 = new Product(2, 21, 250.0f, catalog2);
            orderedProducts.Add(product);
            orderedProducts.Add(product2);
            InvoiceIn invoiceIn = new InvoiceIn(supplier, worker, 1000.0f, "IN/00052/2002", 31, 12, 2022, orderedProducts);
            InvoiceOut invoiceOut = new InvoiceOut(worker, client, 750.0f, "OUT/10052/2002", 30, 12, 2022, orderedProducts);
            dl.addClient(client);
            dl.addSupplier(supplier);
            dl.addWorker(worker);
            dl.addInvoiceIn(invoiceIn); 
            dl.addInvoiceOut(invoiceOut);
            Assert.IsNotNull(dl.getInvoiceOut(0));
            Assert.IsNotNull(dl.getInvoiceIn(0));
            dl.removeWorker(0);
            dl.removeSupplier(0);
            dl.removeClient(0);
            dl.removeInvoiceIn(0);
            dl.removeInvoiceOut(0);
            Assert.AreEqual(0, dl.Worker.Count);
            Assert.AreEqual(0, dl.Client.Count);
            Assert.AreEqual(0, dl.Supplier.Count);
            Assert.AreEqual(0, dl.InvoiceOut.Count);
            Assert.AreEqual(0, dl.InvoiceIn.Count);
        }
    }
}