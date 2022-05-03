using AlAhlyMomkn.DTO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlAhlyMomkn.DAL.Models
{
    public partial class Step
    {
        public static Step Clone(StepDto stepDto)
        {
            Step step = new Step()
            {
                Id = stepDto.Id,
                stepName=stepDto.stepName,
                stepNumber=stepDto.stepNumber,
            };
            return step;
        }
        public static StepDto Clone(Step step)
        {
            StepDto stepDto = new StepDto()
            {
                Id = step.Id,
                stepName = step.stepName,
                stepNumber = step.stepNumber,
            };
            return stepDto;
        }
    }
}
