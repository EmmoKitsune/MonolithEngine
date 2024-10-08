using System;
using System.Collections.Generic;

public class EntitiesManager
{
    public List<MonolithCore.IBaseEntity> entityRegister;

    public EntitiesManager()
    {
        entityRegister = new List<MonolithCore.IBaseEntity>();
    }

    public void AddEntity(MonolithCore.IBaseEntity entity)
    {
        entityRegister.Add(entity);
    }

    public void callInitMethod()
    {
        foreach (var entity in entityRegister)
        {
            entity.setup();
        }
    }
}
