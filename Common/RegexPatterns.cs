﻿namespace Common;

public static class RegexPatterns
{
    public const string Phone = @"^\+7\d{10}$";
    public const string Email = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    public const string Password = @"^(?=.*\d).+$";
    public const string IcdCode = @"^[A-Z]\d{2}(\.\d{1,2})?([-][A-Z]\d{2})?$";
}