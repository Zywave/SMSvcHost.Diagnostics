﻿using System.ServiceModel;
using System.Threading.Tasks;

namespace SMLogging.Lab.Client
{
    public class LabServiceProxy : ClientBase<ILabService>, ILabService
    {
        public string GetData(int value)
        {
            return Channel.GetData(value);
        }

        public async Task<string> GetData2(int value)
        {
            return await Channel.GetData2(value);
        }

        public void DoSomething(int value)
        {
            Channel.DoSomething(value);
        }
    }
}
