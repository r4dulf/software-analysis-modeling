using System;
using System.Collections.Generic;

namespace SmartHomePlatform
{
    public enum UserRole
    {
        User,
        Admin
    }

    public enum DeviceStatus
    {
        Off,
        On,
        Standby,
        Error
    }

    public enum TriggerType
    {
        Time,
        Sensor,
        DeviceState
    }

    public enum ActionType
    {
        TurnOn,
        TurnOff,
        ChangeMode,
        SetValue,
        Notify
    }

    public enum NotificationType
    {
        Info,
        Warning,
        Alert
    }
}