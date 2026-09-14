using System.Collections.Generic;
using System.Text.RegularExpressions;


public class LRUCache {
    private int _capacity;
    private LinkedList<(int key, int value)> _lruList;
    private Dictionary<int, LinkedListNode<(int key, int value)>> _cache;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _lruList = new LinkedList<(int, int)>();
        _cache = new Dictionary<int, LinkedListNode<(int, int)>>();
    }
    
    public int Get(int key) {
        if (!_cache.ContainsKey(key)) {
            return -1;
        }

        var node = _cache[key];
        _lruList.Remove(node);
        _lruList.AddFirst(node);
        return node.Value.value;
    }
    
    public void Put(int key, int value) {
        if (_cache.ContainsKey(key)) {
            var node = _cache[key];
            node.Value = (key, value);
            _lruList.Remove(node);
            _lruList.AddFirst(node);
            return;
        }

        if (_cache.Count >= _capacity) {
            var lruNode = _lruList.Last;
            if (lruNode != null) {
                _cache.Remove(lruNode.Value.key);
                _lruList.RemoveLast();
            }
        }

        var newNode = _lruList.AddFirst((key, value));
        _cache[key] = newNode;
        }
    }












    // private int _capacity;
    // private LinkedList<(int key, int value)> _lruList;
    // private Dictionary<int, LinkedListNode<(int key, int value)>> _cache;

    // public LRUCache(int capacity) {
    //     _capacity = capacity;
    //     _lruList = new LinkedList<(int, int)>();
    //     _cache = new Dictionary<int, LinkedListNode<(int, int)>>();
    // }
    
    // public int Get(int key) {
    //     if (!_cache.ContainsKey(key)) {
    //         return -1;
    //     }

    //     var node = _cache[key];
    //     _lruList.Remove(node);
    //     _lruList.AddFirst(node);
    //     return node.Value.value;
    // }
    
    // public void Put(int key, int value) {
    //     if (_cache.ContainsKey(key)) {
    //         var node = _cache[key];
    //         node.Value = (key, value);
    //         _lruList.Remove(node);
    //         _lruList.AddFirst(node);
    //         return;
    //     }

    //     if (_cache.Count >= _capacity) {
    //         var lruNode = _lruList.Last;
    //         if (lruNode != null) {
    //             _cache.Remove(lruNode.Value.key);
    //             _lruList.RemoveLast();
    //         }
    //     }

    //     var newNode = _lruList.AddFirst((key, value));
    //     _cache[key] = newNode;