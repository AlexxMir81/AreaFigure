using AreaFigure.Services;
using Microsoft.AspNetCore.Mvc;

namespace AreaFigure.Controllers
{
    [Route("CalculateArea")]
    public class AreaCalculatorController : ControllerBase
    {
        private readonly AreaCalculator _areaCalculator;
        public AreaCalculatorController(AreaCalculator areaCalculator)
        {
            _areaCalculator = areaCalculator ?? throw new ArgumentNullException(nameof(areaCalculator)); ;
        }
        [HttpGet("circle")]
        public IActionResult CircleArea(double radius)
        {
            var cirlce = new Circle(radius);
            var result = _areaCalculator.calulateArea(cirlce);
            if (result > 0)
            {
                return Ok(result.ToString());
            }else return BadRequest("Введено некорректное значение радиуса");
        }
        [HttpGet("triangle")]
        public IActionResult TriangleArea(double sidaA, double sidaB, double sidaC)
        {
            var triangle = new Triangle(sidaA, sidaB, sidaC);
            var result = _areaCalculator.calulateArea(triangle);
            if (result > 0)
            {
                return Ok(result.ToString());
            }
            else return BadRequest("Введены некорректные значения сторон");
        }

        [HttpGet("righttriangle")]
        public IActionResult IsRightTraingle(double sidaA, double sidaB, double sidaC)
        {
            var triangle = new Triangle(sidaA, sidaB, sidaC);
            var result = triangle.IsRightTraingle();
            return Ok(result.ToString());
        }
    }
}
