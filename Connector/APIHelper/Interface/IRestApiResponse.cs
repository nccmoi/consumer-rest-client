﻿using System.Net;

namespace Connector.APIHelper.Interface
{
    public interface IRestApiResponse
    {
        /// <summary>Gets the HTTP status code.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        HttpStatusCode GetHttpStatusCode();

        /// <summary>Gets the exception.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        Exception GetException();
    }
}
