namespace CodeQuery.Postman.UI.Models;

#pragma warning disable CS8618, CS8601, CS8603
public partial struct ValueUnion
{
    public bool? Bool;
    public ValueValue? Enum;

    public static implicit operator ValueUnion(bool Bool) => new ValueUnion { Bool = Bool };
    public static implicit operator ValueUnion(ValueValue Enum) => new ValueUnion { Enum = Enum };
}