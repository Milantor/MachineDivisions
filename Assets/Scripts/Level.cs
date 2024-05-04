using UnityEngine;

public class Level
{
	private GameObject[] tiles;
	public Level(int x, int y, Sprite sprite)
	{
		tiles = new GameObject[x * y];
		for (var i = 0; i < y; i++)
		{
			for (var j = 0; j < x; j++)
			{
				var opaopa = new Vector3(j, i);
				var popa = new GameObject
				{
					name = $"Tile {i*x+j+1}",
					transform =
					{
						position = GameToUnity(ref opaopa)
					}
				};
				var spriteRenderer = popa.AddComponent<SpriteRenderer>();
				spriteRenderer.sprite = sprite;
				spriteRenderer.sortingOrder = i+j;
				Debug.Log($"{i*x+j+1} {j+1} {i+1}");
			}
		}
		for (var i = 0; i < y; i++)
		{
			for (var j = 0; j < x; j++)
			{
				var opaopa = new Vector3(j, i);
				var popa = new GameObject
				{
					name = $"XTile {i*x+j+1}",
					transform =
					{
						position = GameToUnity(ref opaopa) + new Vector3(0,.25f)
					}
				};
				var spriteRenderer = popa.AddComponent<SpriteRenderer>();
				spriteRenderer.sprite = Random.Range(0,100) > 50 ? sprite : null;
				spriteRenderer.sortingOrder = i+j+1;
				Debug.Log($"X {i*x+j+1} {j+1} {i+1}");
			}
		}
	}

	private Vector3 GameToUnity(ref Vector3 xyz)
	{
		var x = (xyz.x - xyz.y) * .5f;
		var y = -(xyz.x + xyz.y) * .25f;
		var z = xyz.z;

		xyz = new Vector3(x, y, z);
		return xyz;
	}
}
