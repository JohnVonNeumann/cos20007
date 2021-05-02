from clock import Clock


def main():

    clock = Clock()

    for x in range(86400):
        clock.tick()

    print(clock.time)


if __name__ == '__main__':
    main()
