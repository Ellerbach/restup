﻿using System.IO;
using System.Threading.Tasks;

namespace Devkoes.Restup.WebServer.File
{
    public interface IFile
    {
        string ContentType { get; }
        Task<Stream> OpenStreamForReadAsync();
    }
}