using System;

namespace TaskManager
{
    public enum ErrorCode
    {
        MissingArgument = 1,
        MissingValue,
        WrongArgument,
        WrongArgumentNumber
    }

    [Serializable]
    class TaskManagerException : Exception
    {
        public ErrorCode Code { get; }

        public TaskManagerException(ErrorCode code)
        {
            Code = code;
        }
    }
}
