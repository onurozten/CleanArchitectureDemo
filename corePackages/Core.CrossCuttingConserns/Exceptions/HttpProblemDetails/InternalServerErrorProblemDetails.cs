﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConserns.Exceptions.HttpProblemDetails;

public class InternalServerErrorProblemDetails : ProblemDetails
{
    public InternalServerErrorProblemDetails()
    {
        Title = "Internal Server Error";
        Detail = "Internal Server Error";
        Status = StatusCodes.Status500InternalServerError;
        Type = "https://example.com/probs/internal";
    }
}
