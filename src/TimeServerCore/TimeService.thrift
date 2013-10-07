
namespace csharp TimeServer.Thrift

    //Structure for returning Time
	struct TimeInfoStruct
	{
		1: string Time;
	}

	//Service
	service TimeService
	{
		TimeInfoStruct GetTime()
	}
