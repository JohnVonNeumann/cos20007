class Counter(object):

    def __init__(self, name: str):
        self._count = 0
        self._name = name

    # Methods
    def increment(self):
        self._count += 1

    def reset(self):
        self._count = 0

    # Properties
    @property
    def name(self) -> str:
        return self._name

    @name.setter
    def name(self, name):
        self._name = name

    @property
    def ticks(self) -> int:
        return self._count
