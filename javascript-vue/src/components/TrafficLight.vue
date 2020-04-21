<template>
    <div>
        <div class="flex flex-col items-center p-4 border-4 border-blue-600 rounded-lg">
            <TrafficLightBulb
                :colour="'Red'"
                :on="redOn" />

            <TrafficLightBulb
                :colour="'RedYellow'"
                :on="yellowOn" />

            <TrafficLightBulb
                :colour="'Green'"
                :on="greenOn" />
        </div>
        <div
            class="flex flex-col mt-10"
            data-hello-world>
            <TrafficLightButton
                class="mb-2"
                data-next-state
                @click="nextState">
                Next State
            </TrafficLightButton>
            <TrafficLightButton
                data-off
                @click="turnOff">
                Turn Off
            </TrafficLightButton>
        </div>
    </div>
</template>

<script>
import TrafficLightBulb from './TrafficLightBulb';
import TrafficLightButton from './TrafficLightButton';

import {
    Off, Red, RedYellow, Green,
} from './traffic-light-states';

export default {
    name: 'TrafficLight',

    components: {
        TrafficLightBulb,
        TrafficLightButton,
    },

    data () {
        return {
            state: Off,
        };
    },

    computed: {
        redOn () {
            return this.state === Red || this.state === RedYellow;
        },

        yellowOn () {
            return this.state === RedYellow;
        },

        greenOn () {
            return this.state === Green;
        },
    },

    created () {
        this.colour = this.initial;
    },

    methods: {
        nextState () {
            const lookup = {
                Off: Red,
                Red: RedYellow,
                RedYellow: Green,
                Green: Red,
            };

            this.state = lookup[this.state];
        },

        turnOff () {
            this.state = Off;
        },
    },
};
</script>