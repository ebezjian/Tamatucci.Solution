using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TamaTucci.Models;
using System;

namespace TamaTucci.Tests
{
  [TestClass]
  public class TucciTest // will we need the IDisposable thing here?? maybe.
  {
    // and if we do that stuff will go here

    [TestMethod]
    public void TucciConstructor_GivesLifeToANewTamaTucci_ResultIsANewTucci()
    // test to create a single tucci
    {
      Tucci newTucci = new Tucci("Birthatucci");
      Assert.AreEqual(typeof(Tucci), newTucci.GetType());
    }

    // [TestMethod]
    // test to save the name of an individual tucci
    // {
    // }

    // [TestMethod]
    // test to assign an id to a tucci
    // {
    // }

    // [TestMethod]
    // test to retrieve list of all tuccis
    // {
    // }

    // [TestMethod]
    // test to retrieve a single tucci (by id)
    // {
    // }















  }
}