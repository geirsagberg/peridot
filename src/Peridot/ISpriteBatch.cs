﻿// Copyright (c) 2021 ezequias2d <ezequiasmoises@gmail.com> and the Peridot contributors
// This code is licensed under MIT license (see LICENSE for details)

using System.Drawing;
using System.Numerics;

namespace Peridot
{
    /// <summary>
    /// Represents a interface for drawing sprites in one or more optimized batches.
    /// </summary>
    public interface ISpriteBatch : IDisposable
    {
        /// <summary>
        /// A bool indicating whether this instance has been disposed.
        /// </summary>
        public bool IsDisposed { get; }

        /// <summary>
        /// The view matrix to use to renderer.
        /// </summary>
        public Matrix4x4 ViewMatrix { get; set; }

        /// <summary>
        /// The scissor rectangle.
        /// </summary>
        public RectangleF Scissor { get; set; }

        /// <summary>
        /// Resets the <see cref="Scissor"/> to default value.
        /// </summary>
        public void ResetScissor();

        /// <summary>
        /// Replaces the <see cref="Scissor"/> with the intersection of itself 
        /// and the <paramref name="clip"/> rectangle.
        /// </summary>
        /// <param name="clip">The rectangle to intersects.</param>
        public void IntersectScissor(RectangleF clip);

        /// <summary>
        /// Begins the sprite branch.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown if <see cref="Begin"/> is called next time without previous <see cref="End"/>.</exception>
        public void Begin();

        /// <summary>
        /// Flushes all batched text and sprites to the screen.
        /// </summary>
        /// <exception cref="InvalidOperationException">This command should be called after <see cref="Begin"/> and drawing commands.</exception>
        public void End();

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                float scale,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(ITexture2D texture,
                    Vector2 position,
                    RectangleF? sourceRectangle,
                    Color color,
                    float rotation,
                    Vector2 origin,
                    float scale,
                    float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                RectangleF? sourceRectangle,
                Color color,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                RectangleF? sourceRectangle,
                Color color,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                Vector2 position,
                Color color,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                Vector2 position,
                Color color,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                Color color,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(ITexture2D texture,
                RectangleF destinationRectangle,
                Color color,
                float layerDepth);
    }

    /// <summary>
    /// Represents a interface for drawing sprites in one or more optimized batches.
    /// </summary>
    public interface ISpriteBatch<TTexture> : ISpriteBatch where TTexture : notnull, ITexture2D
    {
        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
                RectangleF destinationRectangle,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
                Vector2 position,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
                RectangleF destinationRectangle,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
                Vector2 position,
                RectangleF sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(TTexture texture,
            RectangleF destinationRectangle,
            RectangleF? sourceRectangle,
            Color color,
            float rotation,
            Vector2 origin,
            SpriteOptions options,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(TTexture texture,
            RectangleF destinationRectangle,
            RectangleF? sourceRectangle,
            Color color,
            float rotation,
            Vector2 origin,
            float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(TTexture texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit sprite draw in the batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">The rotation of the sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(TTexture texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                Vector2 scale,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                float scale,
                SpriteOptions options,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="rotation">A rotation of this sprite.</param>
        /// <param name="origin">Sprite center.</param>
        /// <param name="scale">A scaling of this sprite.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
		public void Draw(TTexture texture,
                Vector2 position,
                RectangleF? sourceRectangle,
                Color color,
                float rotation,
                Vector2 origin,
                float scale,
                float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            Vector2 position,
            RectangleF? sourceRectangle,
            Color color,
            SpriteOptions options,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            Vector2 position,
            RectangleF? sourceRectangle,
            Color color,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            RectangleF destinationRectangle,
            RectangleF? sourceRectangle,
            Color color,
            SpriteOptions options,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="sourceRectangle">An optional region on the texture which will be rendered. If null - draws full texture.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            RectangleF destinationRectangle,
            RectangleF? sourceRectangle,
            Color color,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            Vector2 position,
            Color color,
            SpriteOptions options,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="position">The drawing location on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            Vector2 position,
            Color color,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="options">Options that modify the drawing.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            RectangleF destinationRectangle,
            Color color,
            SpriteOptions options,
            float layerDepth);

        /// <summary>
        /// Submit a sprite for drawing in the current batch.
        /// </summary>
        /// <param name="texture">The source texture.</param>
        /// <param name="destinationRectangle">The drawing bounds on screen.</param>
        /// <param name="color">Color multiplier.</param>
        /// <param name="layerDepth">A depth of the layer of this sprite.</param>
        public void Draw(TTexture texture,
            RectangleF destinationRectangle,
            Color color,
            float layerDepth);
    }
}
