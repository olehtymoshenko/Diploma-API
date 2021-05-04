﻿using System;
using System.Linq;
using BL.Interfaces.Subdomains.FilesGeneration;
using DL.Entities.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace BL.Subdomains.FilesGeneration
{
    public class FileHandlerFactory : IFileHandlerFactory
    {
        readonly IServiceProvider _serviceProvider;

        public FileHandlerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public INotesOfAuthorsHandler GetNotesOfAuthorsHandler(FileFormat fileFormat)
        {
            var notesOfAuthorsHandlers = _serviceProvider.GetServices<INotesOfAuthorsHandler>();

            var handler = notesOfAuthorsHandlers.FirstOrDefault(h => h.Format == fileFormat);

            return handler ?? throw new ArgumentException($"{FileType.NoteOfAuthors} file type isn't supported in " +
                                                          $"{fileFormat} format");
        }
    }
}