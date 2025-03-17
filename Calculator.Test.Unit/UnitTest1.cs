using CalculatorApp;
using NUnit.Framework;
namespace Calculator.Test.Unit;

public class CalculatorUnitTest{
    private Calc? _uut;

    [SetUp]
    public void Setup(){
        _uut = new Calc();
    }

    /*******************************************************
    *                                                     *
    *                   AddInts                           *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void test_AddInts(){
        double result = _uut.add(6, 7);
        Assert.That(result, Is.EqualTo(13.0));
    }

    [Test]
    public void test_AddInts_Negative(){
        double result = _uut.add(-6, -7);
        Assert.That(result, Is.EqualTo(-13.0));
    }

    [Test]
    public void test_AddInts_Zero(){
        double result = _uut.add(0, 7);
        Assert.That(result, Is.EqualTo(7.0));
    }

    /*******************************************************
    *                                                     *
    *                   AddFloats                         *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void TEST_AddFloats()
    {
        double result = _uut.add(242.22, 34.33);
        Assert.That(result, Is.EqualTo(276.55).Within(0.01));
    }

    [Test]
    public void TEST_AddFloats_Negative()
    {
        double result = _uut.add(-242.22, -34.33);
        Assert.That(result, Is.EqualTo(-276.55).Within(0.01));
    }

    [Test]
    public void TEST_AddFloats_Zero()
    {
        double result = _uut.add(0, 34.33);
        Assert.That(result, Is.EqualTo(34.33).Within(0.01));
    }

    /*******************************************************
    *                                                     *
    *                   SubtractInts                      *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void TEST_SubtractInts()
    {
        double result = _uut.subtract(44, 22);
        Assert.That(result, Is.EqualTo(22));
    }

    [Test]
    public void TEST_SubtractInts_Negative()
    {
        double result = _uut.subtract(-44, -22);
        Assert.That(result, Is.EqualTo(-22));
    }

    [Test]
    public void TEST_SubtractInts_Zero()
    {
        double result = _uut.subtract(0, 22);
        Assert.That(result, Is.EqualTo(-22));
    }

    /*******************************************************
    *                                                     *
    *                   SubtractFloats                    *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void TEST_SubtractFloats()
    {
        double result = _uut.subtract(33.22, 26.11);
        Assert.That(result, Is.EqualTo(7.11).Within(0.01));
    }

    [Test]
    public void TEST_SubtractFloats_Negative()
    {
        double result = _uut.subtract(-33.22, -26.11);
        Assert.That(result, Is.EqualTo(-7.11).Within(0.01));
    }

    [Test]
    public void TEST_SubtractFloats_Zero()
    {
        double result = _uut.subtract(0, 26.11);
        Assert.That(result, Is.EqualTo(-26.11).Within(0.01));
    }

    /*******************************************************
    *                                                     *
    *                   Modulus                           *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void TEST_Modulus()
    {
        double result = _uut.Modulus(5, 10);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void TEST_Modulus_Negative()
    {
        double result = _uut.Modulus(-5, 10);
        Assert.That(result, Is.EqualTo(-5));
    }

    [Test]
    public void TEST_Modulus_Zero()
    {
        double result = _uut.Modulus(0, 10);
        Assert.That(result, Is.EqualTo(0));
    }

    /*******************************************************
    *                                                     *
    *                   AddNEW                            *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void Test_AddNEW()
    {
        double result = _uut.AddNEW(5);
        
        double result2 = _uut.AddNEW(5);
      
        Assert.That(_uut.Accumulator, Is.EqualTo(10.0));
    }

    [Test]
    public void Test_AddNEW_Negative()
    {
        double result = _uut.AddNEW(-5);
       
        Assert.That(_uut.Accumulator, Is.EqualTo(-5.0));
    }

    [Test]
    public void Test_AddNEW_Zero()
    {
        double result = _uut.AddNEW(0);
     
        Assert.That(_uut.Accumulator, Is.EqualTo(0.0));
    }

    /*******************************************************
    *                                                     *
    *                   SubtractNEW                       *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void Test_SubtractNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.SubtractNEW(5);
      
        Assert.That(_uut.Accumulator, Is.EqualTo(5.0));
    }

    [Test]
    public void Test_Negative_SubtractNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.SubtractNEW(-5);
       
        Assert.That(_uut.Accumulator, Is.EqualTo(15.0));
    }

    [Test]
    public void Test_Zero_SubtractNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.SubtractNEW(0);
      
        Assert.That(_uut.Accumulator, Is.EqualTo(10.0));
    }

    /*******************************************************
    *                                                     *
    *                   MultiplyNEW                       *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void Test_MultiplyNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.MultiplyNEW(5);
      
        Assert.That(_uut.Accumulator, Is.EqualTo(50.0));
    }

    [Test]
    public void Test_Negative_MultiplyNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.MultiplyNEW(-5);
        
        Assert.That(_uut.Accumulator, Is.EqualTo(-50.0));
    }

    [Test]
    public void Test_Zero_MultiplyNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.MultiplyNEW(0);
        
        Assert.That(_uut.Accumulator, Is.EqualTo(0.0));
    }

    /*******************************************************
    *                                                     *
    *                   PowerNEW                          *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void Test_PowerNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.PowerNEW(2);
      
        Assert.That(_uut.Accumulator, Is.EqualTo(100.0));
    }

    [Test]
    public void Test_Negative_PowerNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.PowerNEW(-2);
       
        Assert.That(_uut.Accumulator, Is.EqualTo(0.01));
    }

    [Test]
    public void Test_Zero_PowerNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.PowerNEW(0);
       
        Assert.That(_uut.Accumulator, Is.EqualTo(1.0));
    }

    /*******************************************************
    *                                                     *
    *                   DivideNEW                         *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void Test_DivideNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.DivideNEW(2);
      
        Assert.That(_uut.Accumulator, Is.EqualTo(5.0));
    }

    [Test]
    public void Test_zero_DivideNEW()
    {
        _uut.AddNEW(10);
       
        Assert.That(_uut.Accumulator, Is.EqualTo(10));
    }

    [Test]
    public void Test_Divide_NegativeNEW()
    {
        _uut.AddNEW(10);
        double result = _uut.DivideNEW(-2);
       
        Assert.That(_uut.Accumulator, Is.EqualTo(-5.0));
    }

    /*******************************************************
    *                                                     *
    *                   Clear                             *
    *                                                     *
    *                   3 test                            *
    *                                                     *
    *******************************************************/

    [Test]
    public void Test_Clear()
    {
        _uut.AddNEW(10);
        _uut.Clear();
        Assert.That(_uut.Accumulator, Is.EqualTo(0.0));
    }

    [Test]
    public void Test_Clear_AfterOperations()
    {
        _uut.AddNEW(10);
        _uut.SubtractNEW(5);
        _uut.MultiplyNEW(2);
        _uut.Clear();
        Assert.That(_uut.Accumulator, Is.EqualTo(0.0));
    }

    [Test]
    public void Test_Clear_WithoutOperations()
    {
        _uut.Clear();
        Assert.That(_uut.Accumulator, Is.EqualTo(0.0));
    }
}
