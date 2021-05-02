from counter import Counter


class Clock(object):

    def __init__(self, name: str):
        self._seconds = Counter("Seconds")
        self._minutes = Counter("Minutes")
        self._hours = Counter("Hours")

    @property
    def time(self) -> str:
        return '{0}:{1}:{2}'.format(self._seconds.ticks, self._minutes.ticks, self._hours.ticks)

    def tick(self) -> None:
        if (self._seconds.ticks != 59):
            self._seconds += 1
        else:
            self._seconds.reset()
            if (self._minutes.ticks != 59):
                self._minutes += 1
            else:
                self._minutes.reset()
                if (self._hours.ticks != 23):
                    self._hours += 1
                else:
                    raise Exception("Out of time! This clock can only go to 24 hours!")