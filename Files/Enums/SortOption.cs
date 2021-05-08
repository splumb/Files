﻿namespace Files.Enums
{
    public enum SortOption : byte
    {
        Name,
        DateModified,
        DateCreated,
        Size,
        FileType,
        OriginalPath,
        DateDeleted
    }
    
    public enum GroupOption : byte
    {
        None,
        Name,
        DateModified,
        DateCreated,
        Size,
        FileType,
        OriginalFolder,
        DateDeleted
    }
}