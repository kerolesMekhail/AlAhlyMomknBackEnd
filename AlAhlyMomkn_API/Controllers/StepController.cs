using AlAhlyMomkn.DAL.Models;
using AlAhlyMomkn.DTO.ViewModel;
using AlAhlyMomkn.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlAhlyMomkn_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StepController : ControllerBase
    {
        private readonly IStep _step;
        public StepController(IStep step, IItem item)
        {
            _step = step;
        }

        [HttpGet("FindAll")]
        public IEnumerable<Step> FindAll()
        {
            IEnumerable<Step> steps = _step.FindAll().OrderBy(x => x.stepNumber).AsEnumerable();

            return steps;
        }

        [HttpGet("GetStepById")]
        public ActionResult<StepDto> GetStepById(int Id)
        {
            var step = _step.GetById(Id);

            if (step == null)
            {
                return NotFound("Record not found");
            }

            return Ok(step);
        }

        [HttpPost("AddStep")]
        public ActionResult AddStep([FromBody] StepDto stepDto)
        {
            var step = Step.Clone(stepDto);
            try
            {
                _step.Add(step);
            }
            catch (Exception ex)
            {
                return NotFound("Record not found");
            }

            return Ok(stepDto);
        }

        [HttpGet("DeleteStep")]
        public ActionResult DeleteStep(int Id)
        {
            var step = _step.GetById(Id);
            if (step == null)
            {
                return NotFound("Record not found");
            }

            _step.Delete(step);
            return Ok(step);
        }
    }
}
