namespace SyzygyEngine.Collisions;

internal interface ICollidable
{
    void OnCollision(Collider other);
    void OnCollisionEnter(Collider other);
    void OnCollisionExit(Collider other);
}