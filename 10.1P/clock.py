from counter import Counter


class Clock(object):

    def __init__(self):
        self._seconds = Counter("Seconds")
        self._minutes = Counter("Minutes")
        self._hours = Counter("Hours")

    @property
    def time(self) -> str:
        return '{0:02d}:{1:02d}:{2:02d}'.format(self._hours.ticks, self._minutes.ticks, self._seconds.ticks)

    def tick(self) -> None:
        if (self._seconds.ticks != 59):
            self._seconds.increment()
        else:
            self._seconds.reset()
            if (self._minutes.ticks != 59):
                self._minutes.increment()
            else:
                self._minutes.reset()
                if (self._hours.ticks != 23):
                    self._hours.increment()
                else:
                    raise Exception("Out of time! This clock can only go to 24 hours!")
