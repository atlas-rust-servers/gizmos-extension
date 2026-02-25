using JetBrains.Annotations;
using Network;
using Pool = Facepunch.Pool;

namespace Oxide.Ext.GizmosExt;

internal class DDrawEntry : Pool.IPooled
{
    private SendInfo _info;

    private string _cmd;
    private object[] _args;

    [MustUseReturnValue]
    public static DDrawEntry New(SendInfo info, string command, object[] args)
    {
        var entry = Pool.Get<DDrawEntry>();
        entry._info = info;
        entry._cmd = command;
        entry._args = args;

        return entry;
    }

    public void Send()
    {
        NetWrite write = Net.sv.StartWrite();
        write.PacketID(Message.Type.ConsoleCommand);

        string value = ConsoleSystem.BuildCommand(_cmd, _args);
        write.String(value);

        write.Send(_info);
    }

    void Pool.IPooled.EnterPool()
    {
        if (_info.connections != null)
            Pool.FreeUnmanaged(ref _info.connections);

        _info = default;
        _args = null;
        _cmd = null;
    }

    void Pool.IPooled.LeavePool() { }
}