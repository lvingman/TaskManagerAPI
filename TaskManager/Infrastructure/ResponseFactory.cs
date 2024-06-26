﻿using Microsoft.AspNetCore.Mvc;

namespace TaskManager.DataAccess.Infrastructure;

public static class ResponseFactory
{
    public static IActionResult CreateSuccessResponse(int statusCode, object? data)
    {
        var response = new ApiSuccessResponse()
        {
            Status = statusCode, Data = data
        };
        return new ObjectResult(response)
        {
            StatusCode = statusCode
        };

    }
    
//Este codigo se encarga de devolver respuestas de query (20X y 40X)

    public static IActionResult CreateErrorResponse(int statusCode, params string[] errors)
    {
        var response = new ApiErrorResponse()
        {
            Status = statusCode,
            Error = new List<ApiErrorResponse.ResponseError>()
        };

        foreach (var error in errors)
        {
            response.Error.Add(new ApiErrorResponse.ResponseError() { Error = error });
        }

        return new ObjectResult(response)
        {
            StatusCode = statusCode,
        };
    }

}