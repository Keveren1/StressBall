using System;
using System.Collections.Generic;
using System.Linq;

namespace StressBall.Manager;

public class StressBallDBManager
{
    private StressBallContext _stressBallContext;

    public StressBallDBManager(StressBallContext context)
    {
        _stressBallContext = context;
    }
    
    public List<StressBallData> GetAll(string? accelerationFilter, DateTime? dateTimeFilter)
    {
        IEnumerable<StressBallData> result = _stressBallContext.StressBall; 
    
        return result.ToList();
    }
}

