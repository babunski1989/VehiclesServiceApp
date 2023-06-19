using System;
using System.Collections.Generic;

namespace VehiclesServiceApp.Buisenss
{
    public class OperationManager
    {
        private static OperationManager instance;
        private OperationManager()
        {

        }

        public static OperationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OperationManager();
                }
                return instance;
            }
        }

        public OperationResult Exec(Operation o)
        {
            try
            {
                return o.Execute();
            }
            catch (Exception ex)
            {
                var code = Guid.NewGuid().ToString();
                var message = "An error occured with code " + code;
                var error = $"Date: {DateTime.UtcNow.ToString()} code: {code}, message: {ex.Message}";
                LogError(message);
                return new OperationResult
                {
                    Errors = new List<string> { error }
                };
            }
        }

        public void LogError(string error)
        {
            Console.WriteLine(error);
        }
    }
}
