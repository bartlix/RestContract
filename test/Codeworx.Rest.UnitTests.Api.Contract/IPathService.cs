﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Codeworx.Rest.UnitTests.Model;

namespace Codeworx.Rest.UnitTests.Api.Contract
{
    [RestRoute("api/Path")]
    public interface IPathService
    {
        [RestPost("Com/{textUrl}/{numberUrl}/{idUrl}/{dateUrl}/plex")]
        Task<bool> ComplexPathWithAllParameters(
            [BodyMember]Item itemBody,
            string textQuery,
            int numberQuery,
            Guid idQuery,
            DateTime dateQuery,
            string textUrl,
            int numberUrl,
            Guid idUrl,
            DateTime dateUrl);

        [RestPost("Com/plex")]
        Task<bool> ComplexPathWithBodyParameter([BodyMember] Item item);

        [RestGet("Com/plex")]
        Task<bool> ComplexPathWithoutParameters();

        [RestPut("Com/plex")]
        Task<bool> ComplexPathWithQueryParameters(
            string text,
            int number,
            Guid id,
            DateTime date);

        [RestGet("Com/{text}/{number}/{id}/{date}/plex")]
        Task<bool> ComplexPathWithUrlParameters(
            string text,
            int number,
            Guid id,
            DateTime date);

        [RestPost("{textUrl}/{numberUrl}/{idUrl}/{dateUrl}")]
        Task<bool> EmptyPathWithAllParameters(
            [BodyMember] Item itemBody,
            string textQuery,
            int numberQuery,
            Guid idQuery,
            DateTime dateQuery,
            string textUrl,
            int numberUrl,
            Guid idUrl,
            DateTime dateUrl);

        [RestPost]
        Task<bool> EmptyPathWithBodyParameter([BodyMember] Item item);

        [RestGet]
        Task<bool> EmptyPathWithoutParameters();

        [RestPut]
        Task<bool> EmptyPathWithQueryParameters(
            string text,
            int number,
            Guid id,
            DateTime date);

        [RestGet("{text}/{number}/{id}/{date}")]
        Task<bool> EmptyPathWithUrlParameters(
            string text,
            int number,
            Guid id,
            DateTime date);

        [RestPost("Simple/{textUrl}/{numberUrl}/{idUrl}/{dateUrl}")]
        Task<bool> SimplePathWithAllParameters(
            [BodyMember] Item itemBody,
            string textQuery,
            int numberQuery,
            Guid idQuery,
            DateTime dateQuery,
            string textUrl,
            int numberUrl,
            Guid idUrl,
            DateTime dateUrl);

        [RestPost("Simple")]
        Task<bool> SimplePathWithBodyParameter([BodyMember] Item item);

        [RestGet("Simple")]
        Task<bool> SimplePathWithoutParameters();

        [RestPut("Simple")]
        Task<bool> SimplePathWithQueryParameters(
            string text,
            int number,
            Guid id,
            DateTime date);

        [RestGet("Simple/{text}/{number}/{id}/{date}")]
        Task<bool> SimplePathWithUrlParameters(
            string text,
            int number,
            Guid id,
            DateTime date);
    }
}