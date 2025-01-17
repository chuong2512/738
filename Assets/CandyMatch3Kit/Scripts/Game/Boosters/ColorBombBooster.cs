﻿// Copyright (C) 2017-2020 gamevanilla. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

using UnityEngine;

namespace GameVanilla.Game.Common
{
	/// <summary>
	/// The class that represents the color bomb booster.
	/// </summary>
	public class ColorBombBooster : Booster
	{
        /// <summary>
        /// Resolves this booster.
        /// </summary>
        /// <param name="board">The game board.</param>
        /// <param name="tile">The tile in which to apply the booster.</param>
		public override void Resolve(GameBoard board, GameObject tile)
		{
			var x = tile.GetComponent<Tile>().x;
			var y = tile.GetComponent<Tile>().y;
			board.ExplodeTile(tile);
			board.CreateColorBomb(x, y);
		}
	}
}
