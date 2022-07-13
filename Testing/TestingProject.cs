using NUnit.Framework;
using NUnit.Framework.Internal;
using ShoppingCart_ASP.NET_MVC5.Models;
using System.ComponentModel.DataAnnotations;
using ShoppingCart_ASP.NET_MVC5.Controllers;
using System;

namespace Testing
{
    public class TestingProject
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void username()
        {
            Customer customer = new Customer();
            string expect = "sivani";
            string Actual = customer.username = "sivani";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void password()
        {
            Customer customer = new Customer();
            string expect = "indra";
            string Actual = customer.password = "indra";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void customerid()
        {
            Customer customer = new Customer();
            int expect = 201;
            int Actual = customer.customer_id = 201;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void firstname()
        {
            Customer customer = new Customer();
            string expect = "sivani";
            string Actual = customer.firstname = "sivani";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void sessionid()
        {
            Customer customer = new Customer();
            string expect = "32551a3c-594d-4023-8867-a0f55ec54c61";
            string Actual = customer.session_id = "32551a3c-594d-4023-8867-a0f55ec54c61";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void productid()
        {
            AllItemList items = new AllItemList();
            int expect = 101;
            int Actual = items.pro_id = 101;
            Assert.AreEqual(expect, Actual);
            int expect2 = 102;
            int Actual2 = items.pro_id = 102;
            Assert.AreEqual(expect2, Actual2);
            int expect3 = 103;
            int Actual3 = items.pro_id = 103;
            Assert.AreEqual(expect3, Actual3);
            int expect4 = 104;
            int Actual4 = items.pro_id = 104;
            Assert.AreEqual(expect4, Actual4);
            int expect5 = 105;
            int Actual5 = items.pro_id = 105;
            Assert.AreEqual(expect5, Actual5);
            int expect6 = 106;
            int Actual6 = items.pro_id = 106;
            Assert.AreEqual(expect6, Actual6);

        }
        [Test]
        public void productname()
        {
            AllItemList items = new AllItemList();
            string expect = "Paracetamol";
            string Actual = items.pro_name = "Paracetamol";
            Assert.AreEqual(expect, Actual);
            string expect2 = "Diclofinac";
            string Actual2 = items.pro_name = "Diclofinac";
            Assert.AreEqual(expect2, Actual2);
            string expect3 = "Glibenclamide Metformin";
            string Actual3 = items.pro_name = "Glibenclamide Metformin";
            Assert.AreEqual(expect3, Actual3);
            string expect4 = "Amlodipine";
            string Actual4 = items.pro_name = "Amlodipine";
            Assert.AreEqual(expect4, Actual4);
            string expect5 = "Salbutamol";
            string Actual5 = items.pro_name = "Salbutamol";
            Assert.AreEqual(expect5, Actual5);
            string expect6 = "Avil";
            string Actual6 = items.pro_name = "Avil";
            Assert.AreEqual(expect6, Actual6);

        }
        [Test]
        public void productdescription()
        {
            AllItemList items = new AllItemList();
            string expect = "This pill is used to reduce temperature and each sheet represents below price";
            string Actual = items.pro_desc = "This pill is used to reduce temperature and each sheet represents below price";
            Assert.AreEqual(expect, Actual);
            string expect2 = "This pill is used to reduce body pains and each sheet represents below price";
            string Actual2 = items.pro_desc = "This pill is used to reduce body pains and each sheet represents below price";
            Assert.AreEqual(expect2, Actual2);
            string expect3 = "This pill is used for diabetic melitose and each sheet represents below price";
            string Actual3 = items.pro_desc = "This pill is used for diabetic melitose and each sheet represents below price";
            Assert.AreEqual(expect3, Actual3);
            string expect4 = "This pill is used for Blood Pressure and each sheet represents below price";
            string Actual4 = items.pro_desc = "This pill is used for Blood Pressure and each sheet represents below price";
            Assert.AreEqual(expect4, Actual4);
            string expect5 = "This pill is used to reduce caugh and each sheet represents below price";
            string Actual5 = items.pro_desc = "This pill is used to reduce caugh and each sheet represents below price";
            Assert.AreEqual(expect5, Actual5);
            string expect6 = "This pill is used for allergy and each sheet represents below price";
            string Actual6 = items.pro_desc = "This pill is used for allergy and each sheet represents below price";
            Assert.AreEqual(expect6, Actual6);
        }
        [Test]
        public void productprice()
        {
            AllItemList items = new AllItemList();
            int expect = 150;
            int Actual = items.pro_price = 150;
            Assert.AreEqual(expect, Actual);
            int expect2 = 200;
            int Actual2 = items.pro_price = 200;
            Assert.AreEqual(expect2, Actual2);
            int expect3 = 150;
            int Actual3 = items.pro_price = 150;
            Assert.AreEqual(expect3, Actual3);
            int expect4 = 200;
            int Actual4 = items.pro_price = 200;
            Assert.AreEqual(expect4, Actual4);
            int expect5 = 200;
            int Actual5 = items.pro_price = 200;
            Assert.AreEqual(expect5, Actual5);
            int expect6 = 150;
            int Actual6 = items.pro_price = 150;
            Assert.AreEqual(expect6, Actual6);

        }
        [Test]
        public void productimage()
        {
            AllItemList items = new AllItemList();
            string expect = "paracetamol.jpg";
            string Actual = items.pro_image = "paracetamol.jpg";
            Assert.AreEqual(expect, Actual);
            string expect2 = "diclofinac.jpg";
            string Actual2 = items.pro_image = "diclofinac.jpg";
            Assert.AreEqual(expect2, Actual2);
            string expect3 = "glibenclamide.jpg";
            string Actual3 = items.pro_image = "glibenclamide.jpg";
            Assert.AreEqual(expect3, Actual3);
            string expect4 = "amlodipine.jpg";
            string Actual4 = items.pro_image = "amlodipine.jpg";
            Assert.AreEqual(expect4, Actual4);
            string expect5 = "salbutamol.jpg";
            string Actual5 = items.pro_image = "salbutamol.jpg";
            Assert.AreEqual(expect5, Actual5);
            string expect6 = "avil.jpg";
            string Actual6 = items.pro_image = "avil.jpg";
            Assert.AreEqual(expect6, Actual6);
        }
        [Test]
        public void cartpro_id()
        {
            Cart cart = new Cart();
            int expect = 101;
            int Actual = cart.pro_id = 101;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_name()
        {
            Cart cart = new Cart();
            string expect = "Paracetamol";
            string Actual = cart.pro_name = "Paracetamol";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_desc()
        {
            Cart cart = new Cart();
            string expect = "This pill is used to reduce temperature and each sheet represents below price";
            string Actual = cart.pro_desc = "This pill is used to reduce temperature and each sheet represents below price";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_price()
        {
            Cart cart = new Cart();
            int expect = 150;
            int Actual = cart.pro_price = 150;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_image()
        {
            Cart cart = new Cart();
            string expect = "paracetamol.jpg";
            string Actual = cart.pro_image = "paracetamol.jpg";
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void cartpro_count()
        {
            Cart cart = new Cart();
            int expect = 3;
            int Actual = cart.count = 3;
            Assert.AreEqual(expect, Actual);

        }
        [Test]
        public void purchaseitem_cust_id()
        {
            PurchaseItems pi = new PurchaseItems();
            int expect = 101;
            int Actual = pi.customer_id = 101;
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_id()
        {
            PurchaseItems pi = new PurchaseItems();
            int expect = 101;
            int Actual = pi.customer_id = 101;
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_name()
        {
            PurchaseItems pi = new PurchaseItems();
            string expect = "Paracetamol";
            string Actual = pi.pro_name = "Paracetamol";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_desc()
        {
            PurchaseItems pi = new PurchaseItems();
            string expect = "This pill is used to reduce temperature and each sheet represents below price";
            string Actual = pi.pro_desc = "This pill is used to reduce temperature and each sheet represents below price";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_image()
        {
            PurchaseItems pi = new PurchaseItems();
            string expect = "paracetamol.jpg";
            string Actual = pi.pro_image = "paracetamol.jpg";
            Assert.AreEqual(expect, Actual);
        }
        [Test]
        public void purchaseitem_pro_count()
        {
            PurchaseItems pi = new PurchaseItems();
            int expect = 4;
            int Actual = pi.count = 4;
            Assert.AreEqual(expect, Actual);
        }




    }
}