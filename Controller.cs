using Microsoft.AspNetCore.Mvc;

namespace PRDA;

[ApiController]
[Route("")]
public class Controller : ControllerBase
{
    // try POSTing { "payload": "too long" } to all endpoints

    [HttpPost(nameof(NormalNoOpenApi))]
    public void Post(NormalNoOpenApi _)
    {
        // 400
        // The field Payload must be a string with a maximum length of 2.
    }

    [HttpPost(nameof(Good))]
    public void Post(Good _)
    {
        // 400
        // The field Payload must be a string with a maximum length of 2.
    }

    [HttpPost(nameof(NoOpenApi))]
    public void Post(NoOpenApi _)
    {
        // 400
        // The field Payload must be a string with a maximum length of 2.
    }

    [HttpPost(nameof(NoGood))]
    public void Post(NoGood _)
    {
        // 500
        // System.InvalidOperationException: Record type 'PRDA.NoGood' has validation metadata defined on property 'Payload' that will be ignored.
        // 'Payload' is a parameter in the record primary constructor and validation metadata must be associated with the constructor parameter.
    }

    [HttpPost(nameof(NoValidation))]
    public void Post(NoValidation _)
    {
        // 500
        // System.InvalidOperationException: Record type 'PRDA.NoValidation' has validation metadata defined on property 'Payload' that will be ignored.
        // 'Payload' is a parameter in the record primary constructor and validation metadata must be associated with the constructor parameter.
    }
}
