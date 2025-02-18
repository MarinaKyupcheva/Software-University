﻿using Logger.Core.Factories;
using Logger.Layouts;
using Logger.Loggers;
using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders.Core.Factories
{
    public class AppendarFactory : IAppendarFactory
    {
        public IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel)
        {
            IAppender appender;

            switch (type)
            {
                case nameof(ConsoleAppender):

                    appender = new ConsoleAppender(layout)
                    {
                        ReportLevel = reportLevel
                    };
                    break;
                case nameof(FileAppender):

                    appender = new FileAppender(layout, new LogFile())
                    {
                        ReportLevel = reportLevel
                    };
                    break;
                default:
                    throw new ArgumentException($"{type} is invalid Appender type.");


            }
            return appender;
        }
    }
}
