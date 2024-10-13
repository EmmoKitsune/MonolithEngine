using System;
using System.Collections.Generic;

public class EntitiesManager
{
    public List<MonolithCore.IBaseEntity> entityRegister;

    public EntitiesManager()
    {
        entityRegister = [];
    }

    public void AddEntity(MonolithCore.IBaseEntity entity)
    {
        entityRegister.Add(entity);
    }

    public void CallInitMethod()
    {
        foreach (var entity in entityRegister)
        {
            entity.Setup();
        }
    }

    public void CallUpdateMethod()
    {
        foreach (var entity in entityRegister)
        {
            entity.Update();
        }
    }
    public void CallDrawMethod()
    {
        foreach (var entity in entityRegister)
        {
            entity.Draw();
        }
    }
    public void CallShutdownMethod()
    {
        foreach (var entity in entityRegister)
        {
            entity.Shutdown();
        }
    }
}
