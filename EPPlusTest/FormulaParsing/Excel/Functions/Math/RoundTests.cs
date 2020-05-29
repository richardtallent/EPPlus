using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml.FormulaParsing;
using OfficeOpenXml.FormulaParsing.Excel.Functions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace EPPlusTest.FormulaParsing.Excel.Functions.Math {
	[TestClass]
	public class RoundTests {
		[TestMethod]
		public void RoundPositiveToOnesDownLiteral() {
			var round = new Round();
			var value1 = 123.45;
			var digits = 0;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(123D, result.Result);
		}
		[TestMethod]
		public void RoundPositiveToOnesUpLiteral() {
			var round = new Round();
			var value1 = 123.65;
			var digits = 0;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(124D, result.Result);
		}

		[TestMethod]
		public void RoundPositiveToTenthsDownLiteral() {
			var round = new Round();
			var value1 = 123.44;
			var digits = 1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(123.4D, result.Result);
		}
		[TestMethod]
		public void RoundPositiveToTenthsUpLiteral() {
			var round = new Round();
			var value1 = 123.456;
			var digits = 1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(123.5D, result.Result);
		}
		[TestMethod]
		public void RoundPositiveToTensDownLiteral() {
			var round = new Round();
			double value1 = 124;
			var digits = -1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(120D, result.Result);
		}
		[TestMethod]
		public void RoundPositiveToTensUpLiteral() {
			var round = new Round();
			double value1 = 125;
			var digits = -1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(130D, result.Result);
		}

		[TestMethod]
		public void RoundNegativeToTensDownLiteral() {
			var round = new Round();
			double value1 = -124;
			var digits = -1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(-120D, result.Result);
		}
		[TestMethod]
		public void RoundNegativeToTensUpLiteral() {
			var round = new Round();
			double value1 = -125;
			var digits = -1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(-130D, result.Result);
		}
		[TestMethod]
		public void RoundNegativeToTenthsDownLiteral() {
			var round = new Round();
			var value1 = -123.44;
			var digits = 1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(-123.4D, result.Result);
		}
		[TestMethod]
		public void RoundNegativeToTenthsUpLiteral() {
			var round = new Round();
			var value1 = -123.456;
			var digits = 1;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(-123.5D, result.Result);
		}
		[TestMethod]
		public void RoundNegativeMidwayLiteral() {
			var round = new Round();
			var value1 = -123.5;
			var digits = 0;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(-124D, result.Result);
		}
		[TestMethod]
		public void RoundPositiveMidwayLiteral() {
			var round = new Round();
			var value1 = 123.5;
			var digits = 0;
			var result = round.Execute(new FunctionArgument[]
			{
				new FunctionArgument(value1),
				new FunctionArgument(digits)
			}, ParsingContext.Create());
			Assert.AreEqual(124D, result.Result);
		}
	}
}
