﻿// <copyright file="FlipType.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessor.Samplers
{
    /// <summary>
    /// Provides enumeration over how a image should be flipped.
    /// </summary>
    public enum FlipType
    {
        /// <summary>
        /// Dont flip the image.
        /// </summary>
        None,

        /// <summary>
        /// Flip the image horizontally.
        /// </summary>
        Horizontal,

        /// <summary>
        /// Flip the image vertically.
        /// </summary>
        Vertical,
    }
}
