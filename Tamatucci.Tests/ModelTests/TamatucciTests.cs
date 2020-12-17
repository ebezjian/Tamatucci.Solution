using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TamaTucci.Models;
using System;

namespace TamaTucci.Tests
{
  [TestClass]
  public class TucciTest : IDisposable 
  {
    public void Dispose()
    {
      Tucci.ClearAll();
    }

    [TestMethod]
    public void TucciConstructor_GivesLifeToANewTamaTucci_ResultIsANewTucci()
    // test to create a single tucci
    {
      Tucci newTucci = new Tucci("Birthatucci");
      Assert.AreEqual(typeof(Tucci), newTucci.GetType());
    }

    [TestMethod]
    // test to save the name of an individual tucci
    public void TucciConstructor_SavesNameOfIndividualTucci_String()
    {
      string tucciName = "Jeff Goldblum";

      Tucci newTucci = new Tucci("Jeff Goldblum");
      //converting Tucci into a string to then test
      string tucciFromTucci = newTucci.TucciName;
      Assert.AreEqual(tucciName, tucciFromTucci);
    }

    [TestMethod]
    public void TucciConstructor_InstantiatesWithAnIDAndGetAReturn_Int()
    // test to assign an id to a tucci
    {
      string TucciName = "Jeff Goldblum";
      Tucci newTucci = new Tucci(TucciName);

      int result = newTucci.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void TucciConstructor_MultipleTuccisAddedToListAndAreTargettedByID_RESULT()
    // test to assign an id to a tucci
    {
      string tucciOne = "Jeff Goldblum";
      string tucciTwo = "Tom Cruise";
      string tucciThree = "Steve Buscemi";
      Tucci newTucciOne = new Tucci(tucciOne);
      Tucci newTucciTwo = new Tucci(tucciTwo);
      Tucci newTucciThree = new Tucci(tucciThree);

      int result = newTucciThree.Id;
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    // test to retrieve a single tucci (by id)
    public void Find_ReturnsSingleTucci_Tucci()
    {
      string tucciOne = "Jeff Goldblum";
      string tucciTwo = "Tom Cruise";
      string tucciThree = "Steve Buscemi";
      Tucci newTucciOne = new Tucci(tucciOne);
      Tucci newTucciTwo = new Tucci(tucciTwo);
      Tucci newTucciThree = new Tucci(tucciThree);

      Tucci result = Tucci.Find(3);
      Assert.AreEqual(newTucciThree, result);
    }

    [TestMethod]
    public void TucciConstructor_CanFindStartingValuesForLevels_Int()
    {
      string tuccemi = "Steve Buscemi";
      Tucci myTucci = new Tucci(tuccemi);

      int levelResult = myTucci.HappinessLevel;

      Assert.AreEqual(10, levelResult);
    }















  }
}