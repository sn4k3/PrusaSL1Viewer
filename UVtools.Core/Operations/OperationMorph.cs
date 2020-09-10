﻿/*
 *                     GNU AFFERO GENERAL PUBLIC LICENSE
 *                       Version 3, 19 November 2007
 *  Copyright (C) 2007 Free Software Foundation, Inc. <https://fsf.org/>
 *  Everyone is permitted to copy and distribute verbatim copies
 *  of this license document, but changing it is not allowed.
 */

using Emgu.CV.CvEnum;
using UVtools.Core.Objects;

namespace UVtools.Core.Operations
{
    public sealed class OperationMorph : Operation
    {
        #region Overrides

        public override string Title => "Morph";
        public override string Description =>
            $"Morph Model - " +
            $"Various operations that can be used to change the physical structure of the model or individual layers.";
        public override string ConfirmationText =>
            $"morph model layers {LayerIndexStart} through {LayerIndexEnd}?";

        public override string ProgressTitle =>
            $"Morphing layers {LayerIndexStart} through {LayerIndexEnd}";

        public override string ProgressAction => "Morphing layers";

        #endregion

        #region Properties


        public static StringTag[] MorphOperations => new[]
        {
            new StringTag("Erode - Contracts the boundaries within the object", MorphOp.Erode),
            new StringTag("Dilate - Expands the boundaries within the object", MorphOp.Dilate),
            new StringTag("Gap Closing - Closes small holes inside the objects", MorphOp.Close),
            new StringTag("Noise Removal - Removes small isolated pixels", MorphOp.Open),
            new StringTag("Gradient - Removes the interior areas of objects", MorphOp.Gradient),
        };

        public MorphOp MorphOperation { get; set; } = MorphOp.Erode;

        public uint IterationsStart { get; set; }
        public uint IterationsEnd { get; set; }
        public bool FadeInOut { get; set; }

        public Kernel Kernel { get; set; } = new Kernel();

        #endregion
    }
}
