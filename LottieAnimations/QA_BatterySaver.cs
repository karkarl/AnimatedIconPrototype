﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           6.1.0-build.109+gebc2a6a0a3
//       
//       Command:
//           LottieGen -MinimumUapVersion 11 -Namespace WindowsInternal.ComposableShell.Experiences -Interface ILottieVisual -Language CSharp -InputFile QA_BatterySaver.json
//       
//       Input file:
//           QA_BatterySaver.json (9462 bytes created 10:10-07:00 Mar 30 2020)
//       
//       Invoked on:
//           SIM10FRESH @ 17:59-07:00 Apr 1 2020
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |   105 |
// |--------------------------+-------|
// | Animators                |    13 |
// | Animated brushes         |     1 |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     2 |
// | PathKeyFrameAnimations   |     1 |
// |--------------------------+-------|
// | ContainerVisuals         |     4 |
// | ShapeVisuals             |     4 |
// |--------------------------+-------|
// | ContainerShapes          |     1 |
// | CompositionSpriteShapes  |     7 |
// |--------------------------+-------|
// | Brushes                  |     5 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     2 |
// ------------------------------------
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;

namespace AnimatedIconPrototype
{
    // Name:        QA_BatterySaver
    // Frame rate:  60 fps
    // Frame count: 60
    // Duration:    1000.0 mS
    // ____________________________________________
    // | Theme property | Type  |  Default value  |
    // |________________|_______|_________________|
    // | Foreground     | Color | #FF000000 Black |
    // --------------------------------------------
    sealed class QA_BatterySaver : ILottieVisualSource
    {
        // Animation duration: 1.000 seconds.
        internal const long c_durationTicks = 10000000;

        // Theme property: Foreground.
        internal static readonly Color c_themeForeground = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);

        CompositionPropertySet _themeProperties;
        Color _themeForeground = c_themeForeground;

        // Theme properties.
        public Color Foreground
        {
            get => _themeForeground;
            set
            {
                _themeForeground = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Foreground", ColorAsVector4((Color)_themeForeground));
                }
            }
        }

        public CompositionPropertySet GetThemeProperties(Compositor compositor)
        {
            return EnsureThemeProperties(compositor);
        }

        internal static Vector4 ColorAsVector4(Color color) => new Vector4(color.R, color.G, color.B, color.A);

        CompositionPropertySet EnsureThemeProperties(Compositor compositor)
        {
            if (_themeProperties is null)
            {
                _themeProperties = compositor.CreatePropertySet();
                _themeProperties.InsertVector4("Foreground", ColorAsVector4((Color)Foreground));
            }
            return _themeProperties;
        }

        public ILottieVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;
            EnsureThemeProperties(compositor);

            if (AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new AnimatedVisual(
                        compositor,
                        _themeProperties
                        );
            }

            return null;
        }

        sealed class AnimatedVisual : ILottieVisual
        {
            const long c_durationTicks = 10000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            readonly CompositionPropertySet _themeProperties;
            CompositionColorBrush _themeColor_Foreground;
            CompositionPath _path_0;
            CompositionPath _path_1;
            CompositionPath _path_2;
            CompositionPath _path_3;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            CubicBezierEasingFunction _cubicBezierEasingFunction_1;
            ExpressionAnimation _rootProgress;
            InsetClip _insetClip_0;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            PathKeyFrameAnimation CreatePathKeyFrameAnimation(float initialProgress, CompositionPath initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreatePathKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - -  Offset:<52.7, 58.476>
            // - Path 1.PathGeometry
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(40.1650009F, -8.0369997F));
                    builder.AddLine(new Vector2(40.1650009F, 8.0369997F));
                    builder.AddLine(new Vector2(34.8069992F, 8.0369997F));
                    builder.AddLine(new Vector2(34.8069992F, 24.1110001F));
                    builder.AddLine(new Vector2(-40.1650009F, 24.1110001F));
                    builder.AddLine(new Vector2(-40.1650009F, 7.53499985F));
                    builder.AddCubicBezier(new Vector2(-39.2439995F, 7.14400005F), new Vector2(-35.7000008F, 5.45499992F), new Vector2(-34.8069992F, 4.98099995F));
                    builder.AddLine(new Vector2(-34.8069992F, 18.7530003F));
                    builder.AddLine(new Vector2(29.4489994F, 18.7530003F));
                    builder.AddLine(new Vector2(29.4489994F, -18.7530003F));
                    builder.AddLine(new Vector2(7.42999983F, -18.7530003F));
                    builder.AddCubicBezier(new Vector2(7.625F, -19.6459999F), new Vector2(7.98799992F, -23.2180004F), new Vector2(8.01599979F, -24.1110001F));
                    builder.AddLine(new Vector2(34.8069992F, -24.1110001F));
                    builder.AddLine(new Vector2(34.8069992F, -8.0369997F));
                    builder.AddLine(new Vector2(40.1650009F, -8.0369997F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-28.9099998F, -8.625F));
                    builder.AddCubicBezier(new Vector2(-28.9099998F, -8.625F), new Vector2(-28.875F, -8.625F), new Vector2(-28.875F, -8.625F));
                    builder.AddCubicBezier(new Vector2(-28.875F, -8.625F), new Vector2(-28.875F, 25.125F), new Vector2(-28.875F, 25.125F));
                    builder.AddCubicBezier(new Vector2(-28.875F, 25.125F), new Vector2(-28.6599998F, 25.125F), new Vector2(-28.6599998F, 25.125F));
                    builder.AddCubicBezier(new Vector2(-28.6599998F, 25.125F), new Vector2(-28.9099998F, -8.625F), new Vector2(-28.9099998F, -8.625F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(31.6919994F, -8.625F));
                    builder.AddCubicBezier(new Vector2(31.6919994F, -8.625F), new Vector2(-28.875F, -8.625F), new Vector2(-28.875F, -8.625F));
                    builder.AddCubicBezier(new Vector2(-28.875F, -8.625F), new Vector2(-28.875F, 25.125F), new Vector2(-28.875F, 25.125F));
                    builder.AddCubicBezier(new Vector2(-28.875F, 25.125F), new Vector2(31.9419994F, 25.125F), new Vector2(31.9419994F, 25.125F));
                    builder.AddCubicBezier(new Vector2(31.9419994F, 25.125F), new Vector2(31.6919994F, -8.625F), new Vector2(31.6919994F, -8.625F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery
            // Saver
            // - - - Masks
            // - -  Offset:<0, 0.5>
            CanvasGeometry Geometry_3()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(61.5F, 43.125F));
                    builder.AddCubicBezier(new Vector2(55.125F, 62.625F), new Vector2(38.25F, 64.25F), new Vector2(32F, 64.25F));
                    builder.AddCubicBezier(new Vector2(25.75F, 64.25F), new Vector2(21.25F, 64.125F), new Vector2(21.25F, 64.125F));
                    builder.AddLine(new Vector2(19.75F, 64.5F));
                    builder.AddLine(new Vector2(19.75F, 74.5F));
                    builder.AddLine(new Vector2(77.125F, 74.5F));
                    builder.AddLine(new Vector2(77.125F, 43.125F));
                    builder.AddLine(new Vector2(61.5F, 43.125F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_4()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-38.875F, 9.5F));
                    builder.AddCubicBezier(new Vector2(-38.875F, 9.5F), new Vector2(-24.5F, 6F), new Vector2(-14.5F, -14.5F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_5()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-27.5F, 2.375F));
                    builder.AddCubicBezier(new Vector2(-27.5F, 2.375F), new Vector2(-39.875F, -7.75F), new Vector2(-28.125F, -23.375F));
                    builder.AddCubicBezier(new Vector2(-19.125F, -32.125F), new Vector2(-12F, -31.25F), new Vector2(-5.375F, -38.75F));
                    builder.AddCubicBezier(new Vector2(-2.375F, -35.875F), new Vector2(4.25F, -28.875F), new Vector2(4.25F, -14.625F));
                    builder.AddCubicBezier(new Vector2(4.25F, -0.375F), new Vector2(-9.375F, 6.125F), new Vector2(-15.125F, 6.125F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - Masks
            // Offset:<0, 0.5>
            CompositionColorBrush ColorBrush_Black()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));
            }

            // Color bound to theme property value: Foreground
            CompositionColorBrush ThemeColor_Foreground()
            {
                var result = _themeColor_Foreground = _c.CreateColorBrush();
                BindProperty(result, "Color", "ColorRGB(_theme.Foreground.W*1,_theme.Foreground.X,_theme.Foreground.Y,_theme.Foreground.Z)", "_theme", _themeProperties);
                return result;
            }

            // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Layer: Shape Layer 6
            CompositionContainerShape ContainerShape()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                var shapes = result.Shapes;
                // Offset:<50, 50>
                shapes.Add(SpriteShape_5());
                // Offset:<50, 50>
                shapes.Add(SpriteShape_6());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation(), _rootProgress);
                return result;
            }

            // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            CompositionEffectBrush EffectBrush()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var effectFactory = _c.CreateEffectFactory(compositeEffect);
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_0());
                result.SetSourceParameter("source", SurfaceBrush_1());
                return result;
            }

            CompositionPath Path_0()
            {
                var result = _path_0 = new CompositionPath(Geometry_1());
                return result;
            }

            CompositionPath Path_1()
            {
                var result = _path_1 = new CompositionPath(Geometry_2());
                return result;
            }

            CompositionPath Path_2()
            {
                var result = _path_2 = new CompositionPath(Geometry_4());
                return result;
            }

            CompositionPath Path_3()
            {
                var result = _path_3 = new CompositionPath(Geometry_5());
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Offset:<52.7, 58.476>
            // Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_0()
            {
                var result = _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
                return result;
            }

            // - - - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - - Transforms for BatterySaver - Charge Offset(0,0.5,0)
            // - Shape tree root for layer: Shape Layer 6
            // Scale:0.95, Offset:<49.25, 50.375>
            // Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_1()
            {
                var result = _c.CreatePathGeometry();
                StartProgressBoundAnimation(result, "Path", PathKeyFrameAnimation_0(), RootProgress());
                return result;
            }

            // - - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - Masks
            // Offset:<0, 0.5>
            CompositionPathGeometry PathGeometry_2()
            {
                var result = _c.CreatePathGeometry(new CompositionPath(Geometry_3()));
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Offset:<50, 50>
            // Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_3()
            {
                var result = _c.CreatePathGeometry(Path_2());
                StartProgressBoundAnimation(result, "TrimStart", TrimStartScalarAnimation_0_to_1_0(), _rootProgress);
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Offset:<50, 50>
            // Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_4()
            {
                var result = _c.CreatePathGeometry(Path_3());
                StartProgressBoundAnimation(result, "TrimStart", TrimStartScalarAnimation_0_to_1_1(), _rootProgress);
                return result;
            }

            // - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - Layer: Shape Layer 6
            // Offset:<50, 50>
            // Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_5()
            {
                var result = _c.CreatePathGeometry(_path_2);
                StartProgressBoundAnimation(result, "TrimEnd", TrimEndScalarAnimation_0_to_1_0(), _rootProgress);
                return result;
            }

            // - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - Layer: Shape Layer 6
            // Offset:<50, 50>
            // Path 1.PathGeometry
            CompositionPathGeometry PathGeometry_6()
            {
                var result = _c.CreatePathGeometry(_path_3);
                StartProgressBoundAnimation(result, "TrimEnd", TrimEndScalarAnimation_0_to_1_1(), _rootProgress);
                return result;
            }

            // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<52.7, 58.476>
                var result = CreateSpriteShape(PathGeometry_0(), new Matrix3x2(1F, 0F, 0F, 1F, 52.7000008F, 58.4760017F), ThemeColor_Foreground());
                return result;
            }

            // - - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - Transforms for BatterySaver - Charge Offset(0,0.5,0)
            // Shape tree root for layer: Shape Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<48.821903, 50.7875>, Rotation:-0.008925567476181147 degrees,
                // Scale:<0.896477, 0.8789875>
                var result = CreateSpriteShape(PathGeometry_1(), new Matrix3x2(0.896476984F, 0F, 0F, 0.878987491F, 48.8219032F, 50.7874985F), _themeColor_Foreground);
                return result;
            }

            // - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Masks
            // Offset:<0, 0.5>
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<0, 0.5>
                var result = CreateSpriteShape(PathGeometry_2(), new Matrix3x2(1F, 0F, 0F, 1F, 0F, 0.5F), ColorBrush_Black());
                return result;
            }

            // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Path 1
            CompositionSpriteShape SpriteShape_3()
            {
                // Offset:<50, 50>
                var result = CreateSpriteShape(PathGeometry_3(), new Matrix3x2(1F, 0F, 0F, 1F, 50F, 50F));
                result.StrokeBrush = _themeColor_Foreground;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 6F;
                return result;
            }

            // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Path 1
            CompositionSpriteShape SpriteShape_4()
            {
                // Offset:<50, 50>
                var result = CreateSpriteShape(PathGeometry_4(), new Matrix3x2(1F, 0F, 0F, 1F, 50F, 50F));
                result.StrokeBrush = _themeColor_Foreground;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 6F;
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Layer: Shape Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_5()
            {
                // Offset:<50, 50>
                var result = CreateSpriteShape(PathGeometry_5(), new Matrix3x2(1F, 0F, 0F, 1F, 50F, 50F));
                result.StrokeBrush = _themeColor_Foreground;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 6F;
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Layer: Shape Layer 6
            // Path 1
            CompositionSpriteShape SpriteShape_6()
            {
                // Offset:<50, 50>
                var result = CreateSpriteShape(PathGeometry_6(), new Matrix3x2(1F, 0F, 0F, 1F, 50F, 50F));
                result.StrokeBrush = _themeColor_Foreground;
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 6F;
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            CompositionSurfaceBrush SurfaceBrush_0()
            {
                var result = _c.CreateSurfaceBrush();
                result.Surface = VisualSurface_0();
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            CompositionSurfaceBrush SurfaceBrush_1()
            {
                var result = _c.CreateSurfaceBrush();
                result.Surface = VisualSurface_1();
                return result;
            }

            // - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            CompositionVisualSurface VisualSurface_0()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_0();
                result.SourceSize = new Vector2(100F, 100F);
                return result;
            }

            // - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            CompositionVisualSurface VisualSurface_1()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_2();
                result.SourceSize = new Vector2(100F, 100F);
                return result;
            }

            // - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            ContainerVisual ContainerVisual_0()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Transforms for BatterySaver - Charge Offset(0,0.5,0)
                result.Children.InsertAtTop(ContainerVisual_1());
                return result;
            }

            // - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Transforms for BatterySaver - Charge Offset(0,0.5,0)
            ContainerVisual ContainerVisual_1()
            {
                var result = _c.CreateContainerVisual();
                result.Clip = _insetClip_0;
                result.Size = new Vector2(100F, 100F);
                // Offset:<0, 0.5>
                result.TransformMatrix = new Matrix4x4(1F, 0F, 0F, 0F, 0F, 1F, 0F, 0F, 0F, 0F, 1F, 0F, 0F, 0.5F, 0F, 1F);
                // Shape tree root for layer: Shape Layer 6
                result.Children.InsertAtTop(ShapeVisual_1());
                return result;
            }

            // - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            ContainerVisual ContainerVisual_2()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Masks
                result.Children.InsertAtTop(ShapeVisual_2());
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                result.Clip = InsetClip_0();
                result.Size = new Vector2(100F, 100F);
                // Offset:<-1, -0.25>, Scale:<0.18, 0.18>
                result.TransformMatrix = new Matrix4x4(0.180000007F, 0F, 0F, 0F, 0F, 0.180000007F, 0F, 0F, 0F, 0F, 0F, 0F, -1F, -0.25F, 0F, 1F);
                var children = result.Children;
                // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
                children.InsertAtTop(ShapeVisual_0());
                // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
                children.InsertAtTop(SpriteVisual_0());
                // PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
                children.InsertAtTop(ShapeVisual_3());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0F, 1F));
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_1()
            {
                return _cubicBezierEasingFunction_1 = _c.CreateCubicBezierEasingFunction(new Vector2(1F, 0F), new Vector2(0.833000004F, 0.833000004F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            InsetClip InsetClip_0()
            {
                var result = _insetClip_0 = _c.CreateInsetClip();
                return result;
            }

            // - - - - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery
            // Saver
            // - - - Transforms for BatterySaver - Charge Offset(0,0.5,0)
            // - - Shape tree root for layer: Shape Layer 6
            // -  Scale:0.95, Offset:<49.25, 50.375>
            // Path 1.PathGeometry
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_0()
            {
                var result = CreatePathKeyFrameAnimation(0F, Path_0(), HoldThenStepEasingFunction());
                result.InsertKeyFrame(0.266666681F, Path_1(), CubicBezierEasingFunction_0());
                result.InsertKeyFrame(0.666666687F, _path_1, _c.CreateCubicBezierEasingFunction(new Vector2(1F, 0F), new Vector2(0F, 1F)));
                result.InsertKeyFrame(0.983333349F, _path_0, CubicBezierEasingFunction_1());
                return result;
            }

            // - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - - Layer: Shape Layer 6
            // -  Offset:<50, 50>
            // Path 1.PathGeometry
            // TrimEnd
            ScalarKeyFrameAnimation TrimEndScalarAnimation_0_to_1_0()
            {
                var result = CreateScalarKeyFrameAnimation(0F, 0F, _stepThenHoldEasingFunction);
                result.InsertKeyFrame(0.400000006F, 0F, _holdThenStepEasingFunction);
                result.InsertKeyFrame(0.649999976F, 1F, _cubicBezierEasingFunction_0);
                return result;
            }

            // - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // - - Layer: Shape Layer 6
            // -  Offset:<50, 50>
            // Path 1.PathGeometry
            // TrimEnd
            ScalarKeyFrameAnimation TrimEndScalarAnimation_0_to_1_1()
            {
                var result = CreateScalarKeyFrameAnimation(0F, 0F, _stepThenHoldEasingFunction);
                result.InsertKeyFrame(0.400000006F, 0F, _holdThenStepEasingFunction);
                result.InsertKeyFrame(0.816666663F, 1F, _cubicBezierEasingFunction_0);
                return result;
            }

            // - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // -  Offset:<50, 50>
            // Path 1.PathGeometry
            // TrimStart
            ScalarKeyFrameAnimation TrimStartScalarAnimation_0_to_1_0()
            {
                var result = CreateScalarKeyFrameAnimation(0F, 0F, _holdThenStepEasingFunction);
                result.InsertKeyFrame(0.300000012F, 1F, _cubicBezierEasingFunction_1);
                return result;
            }

            // - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // -  Offset:<50, 50>
            // Path 1.PathGeometry
            // TrimStart
            ScalarKeyFrameAnimation TrimStartScalarAnimation_0_to_1_1()
            {
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                result.InsertKeyFrame(0.100000001F, 0F, _holdThenStepEasingFunction);
                result.InsertKeyFrame(0.566666663F, 1F, _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.449999988F, 1F)));
                return result;
            }

            // Shape tree root for layer: Layer 1
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(100F, 100F);
                // Offset:<52.7, 58.476>
                result.Shapes.Add(SpriteShape_0());
                return result;
            }

            // - - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Transforms for BatterySaver - Charge Offset(0,0.5,0)
            // Shape tree root for layer: Shape Layer 6
            ShapeVisual ShapeVisual_1()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(100F, 100F);
                // Scale:0.95, Offset:<49.25, 50.375>
                result.Shapes.Add(SpriteShape_1());
                return result;
            }

            // - - - - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Masks
            ShapeVisual ShapeVisual_2()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(100F, 100F);
                // Offset:<0, 0.5>
                result.Shapes.Add(SpriteShape_2());
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_3()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(100F, 100F);
                var shapes = result.Shapes;
                // Offset:<50, 50>
                shapes.Add(SpriteShape_3());
                // Offset:<50, 50>
                shapes.Add(SpriteShape_4());
                // Layer: Shape Layer 6
                shapes.Add(ContainerShape());
                return result;
            }

            // PreComp layer: BatterySaver - Charge
            SpriteVisual SpriteVisual_0()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(100F, 100F);
                result.Brush = EffectBrush();
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _stepThenHoldEasingFunction = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - PreComp layer: Asset - AnimIcon - Action Center - New - Battery Saver
            // Layer: Shape Layer 6
            Vector2KeyFrameAnimation ShapeVisibilityAnimation()
            {
                var result = CreateVector2KeyFrameAnimation(0.400000006F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                return result;
            }

            internal AnimatedVisual(
                Compositor compositor,
                CompositionPropertySet themeProperties
                )
            {
                _c = compositor;
                _themeProperties = themeProperties;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(16F, 16F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
