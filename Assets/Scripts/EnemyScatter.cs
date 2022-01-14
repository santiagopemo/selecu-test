using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScatter : MonoBehaviour
{
    public Movement movement { get; private set; }

    private void Awake()
    {
        this.movement = GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Node node = other.GetComponent<Node>();
        // Do nothing while the ghost is frightened
        if (node != null)
        {
            // Pick a random available direction
            int index = Random.Range(0, node.availableDirections.Count);

            // Prefer not to go back the same direction so increment the index to
            // the next available direction
            if (node.availableDirections[index] == -this.movement.direction && node.availableDirections.Count > 1)
            {
                index++;

                // Wrap the index back around if overflowed
                if (index >= node.availableDirections.Count)
                {
                    index = 0;
                }
            }

            this.movement.SetDirection(node.availableDirections[index]);
        }
    }
}
