﻿namespace CsharpLearning.Services
{
    public interface IMailService
    {
        void SendMail(string to, string subject, string body);
    }
}