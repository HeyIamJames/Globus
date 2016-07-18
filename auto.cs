    using (PowerShell PowerShellInstance = PowerShell.Create())
    {
        PowerShellInstance.AddScript("param($param1) $d = get-date; $s = 'test string value'; " +
                "$d; $s; $param1; get-service");

        PowerShellInstance.AddParameter("param1", "parameter 1 value!");
    }
    
        Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

    if (PowerShellInstance.Streams.Error.Count > 0)
    {
            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
    }
