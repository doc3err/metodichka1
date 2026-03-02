namespace CalculatorModule
{
    public void Add_ShouldReturnSum()
    {
        var calc = new Calculator();
        var result = calc.Add(2, 3);
        Assert.Equal(6, result); // Неправильно, 2+3=5
    }

}
