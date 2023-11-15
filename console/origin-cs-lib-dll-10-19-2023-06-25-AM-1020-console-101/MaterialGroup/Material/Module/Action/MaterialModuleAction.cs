using Core;

namespace Core
{
    using System;

    public partial struct MaterialModule
    {
        public static MaterialModule MaterialModuleAction(Object Object_VALUE, Boolean answer_RENDER_should)
        {
            MaterialModule module;

            module = MaterialModuleDefault(Object_VALUE);

            if (answer_RENDER_should is true)
            {
                try
                {
                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Action}-{nameof(MaterialModule)}Action-Firstoneten", module.First.Function);

                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Action}-{nameof(MaterialModule)}Action-Secondtwotwenty", module.Second.Function);

                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Action}-{nameof(MaterialModule)}Action-Thirdthreethirty", module.Third.Function);

                } catch (Exception exception)
                {
                    Material.Render($"{MaterialCode.RenderPath.Core_Material_Fatal}-{nameof(MaterialModule)}Fatal", exception);
                }
            }
            else
                "false".ToString();

            return module;
        }
    }
}
