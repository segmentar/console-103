using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static MaterialModule MaterialModuleDefault(Object Object_VALUE)
        {
            var reflect = (Material)(Object_VALUE as Object);

            MaterialModule module;

            module = new MaterialModule();

            module.Material = reflect;

            module = ModuleOne(module);

            module = ModuleTwo(module);

            module = ModuleThree(module);

            return module;
        }
    }
}
