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

De{
	NewEngineState=Available
	PreviousEngineState=None
　
	SequenceNumber=13
　
	HostName=ConsoleHost
	HostVersion=3.0
	HostId=d3449f71-9838-4131-8672-a6e76ec7af5d
	EngineVersion=3.0
	RunspaceId=a0f5e0d0-b8e0-4c02-851a-47d1bd1dac32
	PipelineId=
	CommandName=
	CommandType=
	ScriptName=
	CommandPath=
	CommandLine=
}
