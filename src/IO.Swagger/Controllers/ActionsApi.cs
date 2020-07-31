/*
 * six4one
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class ActionsApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="body">Action request for create_story.</param>
        /// <param name="accept"></param>
        /// <param name="acceptCharset"></param>
        /// <param name="acceptEncoding"></param>
        /// <param name="xRequestID"></param>
        /// <response code="200">The action response.</response>
        /// <response code="400">There was something wrong with incoming data from IFTTT. Provide an error response body to clarify what went wrong.</response>
        /// <response code="401">IFTTT sent an OAuth2 access token that isn’t valid.</response>
        /// <response code="404">IFTTT is trying to reach a URL that doesn’t exist.</response>
        /// <response code="429">IFTTT has sent too many requests in a given amount of time.</response>
        /// <response code="500">There was an error in your application logic.</response>
        /// <response code="503">Your service is not available at the moment, but IFTTT should try again later.</response>
        [HttpPost]
        [Route("/ifttt/v1/actions/create_story")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ActionsCreateStoryPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2004), description: "The action response.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ActionErrors), description: "There was something wrong with incoming data from IFTTT. Provide an error response body to clarify what went wrong.")]
        [SwaggerResponse(statusCode: 401, type: typeof(Errors), description: "IFTTT sent an OAuth2 access token that isn’t valid.")]
        [SwaggerResponse(statusCode: 404, type: typeof(Errors), description: "IFTTT is trying to reach a URL that doesn’t exist.")]
        [SwaggerResponse(statusCode: 429, type: typeof(Errors), description: "IFTTT has sent too many requests in a given amount of time.")]
        [SwaggerResponse(statusCode: 500, type: typeof(Errors), description: "There was an error in your application logic.")]
        [SwaggerResponse(statusCode: 503, type: typeof(Errors), description: "Your service is not available at the moment, but IFTTT should try again later.")]
        public virtual IActionResult ActionsCreateStoryPost([FromBody]object body, [FromHeader]string accept, [FromHeader]string acceptCharset, [FromHeader]List<string> acceptEncoding, [FromHeader]string xRequestID)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2004));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ActionErrors));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Errors));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Errors));

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429, default(Errors));

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500, default(Errors));

            //TODO: Uncomment the next line to return response 503 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(503, default(Errors));

            string exampleJson = null;
            exampleJson = "{\n  \"data\" : [ {\n    \"id\" : \"id\",\n    \"url\" : \"url\"\n  }, {\n    \"id\" : \"id\",\n    \"url\" : \"url\"\n  } ]\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse2004>(exampleJson)
            : default(InlineResponse2004);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}